Imports System.Collections.Generic

Public Class Form1

    Dim tempConverter As New TempConvComp.TempConvComp()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFrom.Items.AddRange({"Celsius (°C)", "Reaumur (°R)", "Fahrenheit (°F)", "Kelvin (K)"})
        cmbTo.Items.AddRange({"Celsius (°C)", "Reaumur (°R)", "Fahrenheit (°F)", "Kelvin (K)"})
        txtOutput.ReadOnly = True
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Validate user input
        If String.IsNullOrEmpty(txtInput.Text) OrElse Not IsNumeric(txtInput.Text) Then
            MessageBox.Show("Please enter a valid numeric temperature.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Perform conversion
        Dim inputTemp As Double = CDbl(txtInput.Text)
        Dim convertedTemp As Double = ConvertTemperature(cmbFrom.SelectedItem.ToString(), cmbTo.SelectedItem.ToString(), inputTemp)

        ' Display the result
        txtOutput.Text = $"{convertedTemp:N2}"
        txtOutput.Enabled = False ' Make txtOutput unclickable
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all inputs and outputs
        cmbFrom.SelectedIndex = -1
        cmbTo.SelectedIndex = -1
        txtInput.Clear()
        txtOutput.Clear()
        txtOutput.Enabled = False ' Make txtOutput unclickable
    End Sub

    Private Function ConvertTemperature(fromType As String, toType As String, value As Double) As Double
        ' Perform the actual temperature conversion
        Select Case fromType
            Case "Celsius (°C)"
                Select Case toType
                    Case "Reaumur (°R)"
                        Return tempConverter.cToR(value)
                    Case "Fahrenheit (°F)"
                        Return tempConverter.cToF(value)
                    Case "Kelvin (K)"
                        Return tempConverter.cToK(value)
                End Select
            Case "Reaumur (°R)"
                Select Case toType
                    Case "Celsius (°C)"
                        Return tempConverter.rToC(value)
                    Case "Fahrenheit (°F)"
                        Return tempConverter.rToF(value)
                    Case "Kelvin (K)"
                        Return tempConverter.rToK(value)
                End Select
            Case "Fahrenheit (°F)"
                Select Case toType
                    Case "Celsius (°C)"
                        Return tempConverter.fToC(value)
                    Case "Reaumur (°R)"
                        Return tempConverter.fToR(value)
                    Case "Kelvin (K)"
                        Return tempConverter.fToK(value)
                End Select
            Case "Kelvin (K)"
                Select Case toType
                    Case "Celsius (°C)"
                        Return tempConverter.kToC(value)
                    Case "Reaumur (°R)"
                        Return tempConverter.kToR(value)
                    Case "Fahrenheit (°F)"
                        Return tempConverter.kToF(value)
                End Select
        End Select

        ' Default return value (should not be reached)
        Return 0.0
    End Function

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
End Class
