<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccCalc))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPerf = New System.Windows.Forms.TextBox()
        Me.txtGrt = New System.Windows.Forms.TextBox()
        Me.txtGood = New System.Windows.Forms.TextBox()
        Me.txtBad = New System.Windows.Forms.TextBox()
        Me.txtMiss = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTSG = New System.Windows.Forms.Label()
        Me.lblAcc = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCombo = New System.Windows.Forms.TextBox()
        Me.chkBGM = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("VAG Rounded Std Thin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Perfect: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("VAG Rounded Std Thin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Great:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("VAG Rounded Std Thin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Good:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("VAG Rounded Std Thin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("VAG Rounded Std Thin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Miss:"
        '
        'txtPerf
        '
        Me.txtPerf.Location = New System.Drawing.Point(110, 35)
        Me.txtPerf.MaxLength = 4
        Me.txtPerf.Name = "txtPerf"
        Me.txtPerf.Size = New System.Drawing.Size(113, 19)
        Me.txtPerf.TabIndex = 0
        '
        'txtGrt
        '
        Me.txtGrt.Location = New System.Drawing.Point(110, 71)
        Me.txtGrt.MaxLength = 4
        Me.txtGrt.Name = "txtGrt"
        Me.txtGrt.Size = New System.Drawing.Size(113, 19)
        Me.txtGrt.TabIndex = 1
        '
        'txtGood
        '
        Me.txtGood.Location = New System.Drawing.Point(110, 106)
        Me.txtGood.MaxLength = 4
        Me.txtGood.Name = "txtGood"
        Me.txtGood.Size = New System.Drawing.Size(113, 19)
        Me.txtGood.TabIndex = 2
        '
        'txtBad
        '
        Me.txtBad.Location = New System.Drawing.Point(110, 141)
        Me.txtBad.MaxLength = 4
        Me.txtBad.Name = "txtBad"
        Me.txtBad.Size = New System.Drawing.Size(113, 19)
        Me.txtBad.TabIndex = 3
        '
        'txtMiss
        '
        Me.txtMiss.Location = New System.Drawing.Point(110, 178)
        Me.txtMiss.MaxLength = 4
        Me.txtMiss.Name = "txtMiss"
        Me.txtMiss.Size = New System.Drawing.Size(113, 19)
        Me.txtMiss.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("VAG Rounded Std Thin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(287, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Theoritical Score Get:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("VAG Rounded Std Thin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(287, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Accuracy:"
        '
        'lblTSG
        '
        Me.lblTSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTSG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTSG.Font = New System.Drawing.Font("VAG Rounded Std Thin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTSG.Location = New System.Drawing.Point(287, 54)
        Me.lblTSG.Name = "lblTSG"
        Me.lblTSG.Size = New System.Drawing.Size(185, 52)
        Me.lblTSG.TabIndex = 12
        Me.lblTSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAcc
        '
        Me.lblAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAcc.Font = New System.Drawing.Font("VAG Rounded Std Thin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcc.Location = New System.Drawing.Point(287, 145)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(185, 52)
        Me.lblAcc.TabIndex = 13
        Me.lblAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(397, 222)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(316, 222)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(506, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("VAG Rounded Std Thin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 24)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Combo:"
        '
        'txtCombo
        '
        Me.txtCombo.Location = New System.Drawing.Point(108, 224)
        Me.txtCombo.MaxLength = 4
        Me.txtCombo.Name = "txtCombo"
        Me.txtCombo.Size = New System.Drawing.Size(113, 19)
        Me.txtCombo.TabIndex = 5
        '
        'chkBGM
        '
        Me.chkBGM.AutoSize = True
        Me.chkBGM.BackColor = System.Drawing.Color.Transparent
        Me.chkBGM.Location = New System.Drawing.Point(453, 5)
        Me.chkBGM.Name = "chkBGM"
        Me.chkBGM.Size = New System.Drawing.Size(49, 16)
        Me.chkBGM.TabIndex = 18
        Me.chkBGM.Text = "BGM"
        Me.chkBGM.UseVisualStyleBackColor = False
        '
        'frmAccCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 257)
        Me.Controls.Add(Me.chkBGM)
        Me.Controls.Add(Me.txtCombo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblAcc)
        Me.Controls.Add(Me.lblTSG)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMiss)
        Me.Controls.Add(Me.txtBad)
        Me.Controls.Add(Me.txtGood)
        Me.Controls.Add(Me.txtGrt)
        Me.Controls.Add(Me.txtPerf)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmAccCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMH BangDream Accuracy Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPerf As TextBox
    Friend WithEvents txtGrt As TextBox
    Friend WithEvents txtGood As TextBox
    Friend WithEvents txtBad As TextBox
    Friend WithEvents txtMiss As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTSG As Label
    Friend WithEvents lblAcc As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCombo As TextBox
    Friend WithEvents chkBGM As CheckBox
End Class
