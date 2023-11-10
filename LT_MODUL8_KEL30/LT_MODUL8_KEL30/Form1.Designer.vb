<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnConvert = New Button()
        txtInput = New TextBox()
        cmbFrom = New ComboBox()
        cmbTo = New ComboBox()
        txtOutput = New TextBox()
        btnClear = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(350, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 15)
        Label1.TabIndex = 2
        Label1.Text = "Temperature Converter"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(568, 168)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(87, 23)
        btnConvert.TabIndex = 3
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(452, 125)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(189, 23)
        txtInput.TabIndex = 4
        ' 
        ' cmbFrom
        ' 
        cmbFrom.FormattingEnabled = True
        cmbFrom.Location = New Point(188, 125)
        cmbFrom.Name = "cmbFrom"
        cmbFrom.Size = New Size(189, 23)
        cmbFrom.TabIndex = 5
        ' 
        ' cmbTo
        ' 
        cmbTo.FormattingEnabled = True
        cmbTo.Location = New Point(188, 243)
        cmbTo.Name = "cmbTo"
        cmbTo.Size = New Size(189, 23)
        cmbTo.TabIndex = 8
        ' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(452, 243)
        txtOutput.Name = "txtOutput"
        txtOutput.Size = New Size(189, 23)
        txtOutput.TabIndex = 7
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(568, 286)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(87, 23)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(177, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 9
        Label2.Text = "From"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(177, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(19, 15)
        Label3.TabIndex = 10
        Label3.Text = "To"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cmbTo)
        Controls.Add(txtOutput)
        Controls.Add(btnClear)
        Controls.Add(cmbFrom)
        Controls.Add(txtInput)
        Controls.Add(btnConvert)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents cmbFrom As ComboBox
    Friend WithEvents cmbTo As ComboBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
