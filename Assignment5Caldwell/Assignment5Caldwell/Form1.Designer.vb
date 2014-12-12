<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBoxCurrent = New System.Windows.Forms.TextBox()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.rdoCelsius = New System.Windows.Forms.RadioButton()
        Me.rdoFahrenheit = New System.Windows.Forms.RadioButton()
        Me.rdoKelvin = New System.Windows.Forms.RadioButton()
        Me.rdoRankine = New System.Windows.Forms.RadioButton()
        Me.grpBoxCurrent = New System.Windows.Forms.GroupBox()
        Me.grpBoxConversion = New System.Windows.Forms.GroupBox()
        Me.lblRankine = New System.Windows.Forms.Label()
        Me.lblKelvin = New System.Windows.Forms.Label()
        Me.lblCelFahr = New System.Windows.Forms.Label()
        Me.lblOutput3 = New System.Windows.Forms.Label()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.lblOutput1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpBoxCurrent.SuspendLayout()
        Me.grpBoxConversion.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBoxCurrent
        '
        Me.txtBoxCurrent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBoxCurrent.Location = New System.Drawing.Point(6, 19)
        Me.txtBoxCurrent.Name = "txtBoxCurrent"
        Me.txtBoxCurrent.Size = New System.Drawing.Size(127, 20)
        Me.txtBoxCurrent.TabIndex = 0
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(139, 22)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(0, 13)
        Me.lblTemp.TabIndex = 1
        '
        'rdoCelsius
        '
        Me.rdoCelsius.AutoSize = True
        Me.rdoCelsius.Location = New System.Drawing.Point(6, 46)
        Me.rdoCelsius.Name = "rdoCelsius"
        Me.rdoCelsius.Size = New System.Drawing.Size(36, 17)
        Me.rdoCelsius.TabIndex = 2
        Me.rdoCelsius.Text = "°C"
        Me.rdoCelsius.UseVisualStyleBackColor = True
        '
        'rdoFahrenheit
        '
        Me.rdoFahrenheit.AutoSize = True
        Me.rdoFahrenheit.Location = New System.Drawing.Point(49, 46)
        Me.rdoFahrenheit.Name = "rdoFahrenheit"
        Me.rdoFahrenheit.Size = New System.Drawing.Size(35, 17)
        Me.rdoFahrenheit.TabIndex = 3
        Me.rdoFahrenheit.Text = "°F"
        Me.rdoFahrenheit.UseVisualStyleBackColor = True
        '
        'rdoKelvin
        '
        Me.rdoKelvin.AutoSize = True
        Me.rdoKelvin.Location = New System.Drawing.Point(91, 46)
        Me.rdoKelvin.Name = "rdoKelvin"
        Me.rdoKelvin.Size = New System.Drawing.Size(32, 17)
        Me.rdoKelvin.TabIndex = 4
        Me.rdoKelvin.Text = "K"
        Me.rdoKelvin.UseVisualStyleBackColor = True
        '
        'rdoRankine
        '
        Me.rdoRankine.AutoSize = True
        Me.rdoRankine.Location = New System.Drawing.Point(130, 46)
        Me.rdoRankine.Name = "rdoRankine"
        Me.rdoRankine.Size = New System.Drawing.Size(43, 17)
        Me.rdoRankine.TabIndex = 5
        Me.rdoRankine.Text = "°Ra"
        Me.rdoRankine.UseVisualStyleBackColor = True
        '
        'grpBoxCurrent
        '
        Me.grpBoxCurrent.Controls.Add(Me.txtBoxCurrent)
        Me.grpBoxCurrent.Controls.Add(Me.rdoRankine)
        Me.grpBoxCurrent.Controls.Add(Me.lblTemp)
        Me.grpBoxCurrent.Controls.Add(Me.rdoKelvin)
        Me.grpBoxCurrent.Controls.Add(Me.rdoCelsius)
        Me.grpBoxCurrent.Controls.Add(Me.rdoFahrenheit)
        Me.grpBoxCurrent.Location = New System.Drawing.Point(28, 30)
        Me.grpBoxCurrent.Name = "grpBoxCurrent"
        Me.grpBoxCurrent.Size = New System.Drawing.Size(251, 75)
        Me.grpBoxCurrent.TabIndex = 6
        Me.grpBoxCurrent.TabStop = False
        Me.grpBoxCurrent.Text = "Current Temp"
        '
        'grpBoxConversion
        '
        Me.grpBoxConversion.Controls.Add(Me.lblRankine)
        Me.grpBoxConversion.Controls.Add(Me.lblKelvin)
        Me.grpBoxConversion.Controls.Add(Me.lblCelFahr)
        Me.grpBoxConversion.Controls.Add(Me.lblOutput3)
        Me.grpBoxConversion.Controls.Add(Me.lblOutput2)
        Me.grpBoxConversion.Controls.Add(Me.lblOutput1)
        Me.grpBoxConversion.Location = New System.Drawing.Point(28, 112)
        Me.grpBoxConversion.Name = "grpBoxConversion"
        Me.grpBoxConversion.Size = New System.Drawing.Size(251, 100)
        Me.grpBoxConversion.TabIndex = 7
        Me.grpBoxConversion.TabStop = False
        Me.grpBoxConversion.Text = "Conversions"
        '
        'lblRankine
        '
        Me.lblRankine.AutoSize = True
        Me.lblRankine.Location = New System.Drawing.Point(132, 71)
        Me.lblRankine.Name = "lblRankine"
        Me.lblRankine.Size = New System.Drawing.Size(47, 13)
        Me.lblRankine.TabIndex = 5
        Me.lblRankine.Text = "Rankine"
        '
        'lblKelvin
        '
        Me.lblKelvin.AutoSize = True
        Me.lblKelvin.Location = New System.Drawing.Point(132, 43)
        Me.lblKelvin.Name = "lblKelvin"
        Me.lblKelvin.Size = New System.Drawing.Size(36, 13)
        Me.lblKelvin.TabIndex = 4
        Me.lblKelvin.Text = "Kelvin"
        '
        'lblCelFahr
        '
        Me.lblCelFahr.AutoSize = True
        Me.lblCelFahr.Location = New System.Drawing.Point(132, 20)
        Me.lblCelFahr.Name = "lblCelFahr"
        Me.lblCelFahr.Size = New System.Drawing.Size(0, 13)
        Me.lblCelFahr.TabIndex = 3
        '
        'lblOutput3
        '
        Me.lblOutput3.AutoSize = True
        Me.lblOutput3.Location = New System.Drawing.Point(84, 71)
        Me.lblOutput3.Name = "lblOutput3"
        Me.lblOutput3.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput3.TabIndex = 2
        '
        'lblOutput2
        '
        Me.lblOutput2.AutoSize = True
        Me.lblOutput2.Location = New System.Drawing.Point(84, 43)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput2.TabIndex = 1
        '
        'lblOutput1
        '
        Me.lblOutput1.AutoSize = True
        Me.lblOutput1.Location = New System.Drawing.Point(84, 20)
        Me.lblOutput1.Name = "lblOutput1"
        Me.lblOutput1.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput1.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(28, 241)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(119, 45)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(170, 241)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 45)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(311, 320)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpBoxConversion)
        Me.Controls.Add(Me.grpBoxCurrent)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temp Converter"
        Me.grpBoxCurrent.ResumeLayout(False)
        Me.grpBoxCurrent.PerformLayout()
        Me.grpBoxConversion.ResumeLayout(False)
        Me.grpBoxConversion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBoxCurrent As System.Windows.Forms.TextBox
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents rdoCelsius As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFahrenheit As System.Windows.Forms.RadioButton
    Friend WithEvents rdoKelvin As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRankine As System.Windows.Forms.RadioButton
    Friend WithEvents grpBoxCurrent As System.Windows.Forms.GroupBox
    Friend WithEvents grpBoxConversion As System.Windows.Forms.GroupBox
    Friend WithEvents lblRankine As System.Windows.Forms.Label
    Friend WithEvents lblKelvin As System.Windows.Forms.Label
    Friend WithEvents lblCelFahr As System.Windows.Forms.Label
    Friend WithEvents lblOutput3 As System.Windows.Forms.Label
    Friend WithEvents lblOutput2 As System.Windows.Forms.Label
    Friend WithEvents lblOutput1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
