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
        Me.grbStudentDetails = New System.Windows.Forms.GroupBox()
        Me.txtMobileContact = New System.Windows.Forms.MaskedTextBox()
        Me.txtStdREGnumber = New System.Windows.Forms.MaskedTextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.chkHobbies = New System.Windows.Forms.CheckedListBox()
        Me.lblHobbies = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.rbtFemale = New System.Windows.Forms.RadioButton()
        Me.txtYearofStudy = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtFullNames = New System.Windows.Forms.TextBox()
        Me.rbtMale = New System.Windows.Forms.RadioButton()
        Me.lblYearofstudy = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblStdRegNumber = New System.Windows.Forms.Label()
        Me.lblFullnames = New System.Windows.Forms.Label()
        Me.lblMobileContacts = New System.Windows.Forms.Label()
        Me.grbStudentDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbStudentDetails
        '
        Me.grbStudentDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbStudentDetails.BackColor = System.Drawing.SystemColors.Control
        Me.grbStudentDetails.BackgroundImage = Global.MyStudent.My.Resources.Resources.wallpaperflare_com_wallpaper
        Me.grbStudentDetails.Controls.Add(Me.txtMobileContact)
        Me.grbStudentDetails.Controls.Add(Me.txtStdREGnumber)
        Me.grbStudentDetails.Controls.Add(Me.btnSubmit)
        Me.grbStudentDetails.Controls.Add(Me.chkHobbies)
        Me.grbStudentDetails.Controls.Add(Me.lblHobbies)
        Me.grbStudentDetails.Controls.Add(Me.txtEmail)
        Me.grbStudentDetails.Controls.Add(Me.rbtFemale)
        Me.grbStudentDetails.Controls.Add(Me.txtYearofStudy)
        Me.grbStudentDetails.Controls.Add(Me.lblGender)
        Me.grbStudentDetails.Controls.Add(Me.txtFullNames)
        Me.grbStudentDetails.Controls.Add(Me.rbtMale)
        Me.grbStudentDetails.Controls.Add(Me.lblYearofstudy)
        Me.grbStudentDetails.Controls.Add(Me.lblEmail)
        Me.grbStudentDetails.Controls.Add(Me.lblStdRegNumber)
        Me.grbStudentDetails.Controls.Add(Me.lblFullnames)
        Me.grbStudentDetails.Controls.Add(Me.lblMobileContacts)
        Me.grbStudentDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbStudentDetails.ForeColor = System.Drawing.Color.Red
        Me.grbStudentDetails.Location = New System.Drawing.Point(22, 12)
        Me.grbStudentDetails.Name = "grbStudentDetails"
        Me.grbStudentDetails.Size = New System.Drawing.Size(890, 482)
        Me.grbStudentDetails.TabIndex = 18
        Me.grbStudentDetails.TabStop = False
        Me.grbStudentDetails.Text = "Student Details"
        '
        'txtMobileContact
        '
        Me.txtMobileContact.Location = New System.Drawing.Point(471, 242)
        Me.txtMobileContact.Mask = "(+254) 00000000"
        Me.txtMobileContact.Name = "txtMobileContact"
        Me.txtMobileContact.Size = New System.Drawing.Size(231, 29)
        Me.txtMobileContact.TabIndex = 21
        '
        'txtStdREGnumber
        '
        Me.txtStdREGnumber.Location = New System.Drawing.Point(471, 71)
        Me.txtStdREGnumber.Mask = "00-0000"
        Me.txtStdREGnumber.Name = "txtStdREGnumber"
        Me.txtStdREGnumber.Size = New System.Drawing.Size(231, 29)
        Me.txtStdREGnumber.TabIndex = 20
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmit.BackColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(734, 375)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(141, 43)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'chkHobbies
        '
        Me.chkHobbies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkHobbies.BackColor = System.Drawing.Color.White
        Me.chkHobbies.CheckOnClick = True
        Me.chkHobbies.FormattingEnabled = True
        Me.chkHobbies.Items.AddRange(New Object() {"Swimming", "Skating", "Sleeping", "Watching ", "Reading", "Art", "Music"})
        Me.chkHobbies.Location = New System.Drawing.Point(471, 332)
        Me.chkHobbies.Name = "chkHobbies"
        Me.chkHobbies.Size = New System.Drawing.Size(231, 100)
        Me.chkHobbies.TabIndex = 18
        '
        'lblHobbies
        '
        Me.lblHobbies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHobbies.AutoSize = True
        Me.lblHobbies.BackColor = System.Drawing.Color.Transparent
        Me.lblHobbies.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHobbies.ForeColor = System.Drawing.Color.White
        Me.lblHobbies.Location = New System.Drawing.Point(160, 332)
        Me.lblHobbies.Name = "lblHobbies"
        Me.lblHobbies.Size = New System.Drawing.Size(117, 25)
        Me.lblHobbies.TabIndex = 13
        Me.lblHobbies.Text = "7.Hobbies"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(471, 288)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(231, 29)
        Me.txtEmail.TabIndex = 12
        '
        'rbtFemale
        '
        Me.rbtFemale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbtFemale.AutoSize = True
        Me.rbtFemale.BackColor = System.Drawing.Color.Transparent
        Me.rbtFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFemale.ForeColor = System.Drawing.Color.White
        Me.rbtFemale.Location = New System.Drawing.Point(604, 157)
        Me.rbtFemale.Name = "rbtFemale"
        Me.rbtFemale.Size = New System.Drawing.Size(98, 28)
        Me.rbtFemale.TabIndex = 6
        Me.rbtFemale.TabStop = True
        Me.rbtFemale.Text = "Female"
        Me.rbtFemale.UseVisualStyleBackColor = False
        '
        'txtYearofStudy
        '
        Me.txtYearofStudy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtYearofStudy.BackColor = System.Drawing.Color.White
        Me.txtYearofStudy.Location = New System.Drawing.Point(471, 200)
        Me.txtYearofStudy.Name = "txtYearofStudy"
        Me.txtYearofStudy.Size = New System.Drawing.Size(231, 29)
        Me.txtYearofStudy.TabIndex = 8
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.White
        Me.lblGender.Location = New System.Drawing.Point(160, 160)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(110, 25)
        Me.lblGender.TabIndex = 4
        Me.lblGender.Text = "3.Gender"
        '
        'txtFullNames
        '
        Me.txtFullNames.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFullNames.BackColor = System.Drawing.Color.White
        Me.txtFullNames.Location = New System.Drawing.Point(471, 113)
        Me.txtFullNames.Name = "txtFullNames"
        Me.txtFullNames.Size = New System.Drawing.Size(231, 29)
        Me.txtFullNames.TabIndex = 3
        '
        'rbtMale
        '
        Me.rbtMale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbtMale.AutoSize = True
        Me.rbtMale.BackColor = System.Drawing.Color.Transparent
        Me.rbtMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMale.ForeColor = System.Drawing.Color.White
        Me.rbtMale.Location = New System.Drawing.Point(471, 156)
        Me.rbtMale.Name = "rbtMale"
        Me.rbtMale.Size = New System.Drawing.Size(73, 28)
        Me.rbtMale.TabIndex = 5
        Me.rbtMale.TabStop = True
        Me.rbtMale.Text = "Male"
        Me.rbtMale.UseVisualStyleBackColor = False
        '
        'lblYearofstudy
        '
        Me.lblYearofstudy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblYearofstudy.AutoSize = True
        Me.lblYearofstudy.BackColor = System.Drawing.Color.Transparent
        Me.lblYearofstudy.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearofstudy.ForeColor = System.Drawing.Color.White
        Me.lblYearofstudy.Location = New System.Drawing.Point(160, 203)
        Me.lblYearofstudy.Name = "lblYearofstudy"
        Me.lblYearofstudy.Size = New System.Drawing.Size(179, 25)
        Me.lblYearofstudy.TabIndex = 7
        Me.lblYearofstudy.Text = "4.Year Of Study"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(160, 289)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(94, 25)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "6.Email"
        '
        'lblStdRegNumber
        '
        Me.lblStdRegNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStdRegNumber.AutoSize = True
        Me.lblStdRegNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblStdRegNumber.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdRegNumber.ForeColor = System.Drawing.Color.White
        Me.lblStdRegNumber.Location = New System.Drawing.Point(160, 74)
        Me.lblStdRegNumber.Name = "lblStdRegNumber"
        Me.lblStdRegNumber.Size = New System.Drawing.Size(202, 25)
        Me.lblStdRegNumber.TabIndex = 1
        Me.lblStdRegNumber.Text = "1.Student Number"
        '
        'lblFullnames
        '
        Me.lblFullnames.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFullnames.AutoSize = True
        Me.lblFullnames.BackColor = System.Drawing.Color.Transparent
        Me.lblFullnames.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullnames.ForeColor = System.Drawing.Color.White
        Me.lblFullnames.Location = New System.Drawing.Point(160, 117)
        Me.lblFullnames.Name = "lblFullnames"
        Me.lblFullnames.Size = New System.Drawing.Size(152, 25)
        Me.lblFullnames.TabIndex = 2
        Me.lblFullnames.Text = "2.Full Names"
        '
        'lblMobileContacts
        '
        Me.lblMobileContacts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMobileContacts.AutoSize = True
        Me.lblMobileContacts.BackColor = System.Drawing.Color.Transparent
        Me.lblMobileContacts.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileContacts.ForeColor = System.Drawing.Color.White
        Me.lblMobileContacts.Location = New System.Drawing.Point(160, 246)
        Me.lblMobileContacts.Name = "lblMobileContacts"
        Me.lblMobileContacts.Size = New System.Drawing.Size(192, 25)
        Me.lblMobileContacts.TabIndex = 9
        Me.lblMobileContacts.Text = "5.Mobile Contact"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(924, 506)
        Me.Controls.Add(Me.grbStudentDetails)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grbStudentDetails.ResumeLayout(False)
        Me.grbStudentDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblStdRegNumber As Label
    Friend WithEvents lblFullnames As Label
    Friend WithEvents lblHobbies As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblMobileContacts As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblYearofstudy As Label
    Friend WithEvents txtYearofStudy As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents rbtMale As RadioButton
    Friend WithEvents rbtFemale As RadioButton
    Friend WithEvents grbStudentDetails As GroupBox
    Friend WithEvents chkHobbies As CheckedListBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtFullNames As TextBox
    Friend WithEvents txtStdREGnumber As MaskedTextBox
    Friend WithEvents txtMobileContact As MaskedTextBox
End Class
