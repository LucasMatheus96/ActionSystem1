<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class Frm_Login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Login As System.Windows.Forms.Label
    Friend WithEvents Lbl_Senha As System.Windows.Forms.Label
    Friend WithEvents Txt_Login As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Passoword As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Lbl_Login = New System.Windows.Forms.Label()
        Me.Lbl_Senha = New System.Windows.Forms.Label()
        Me.Txt_Login = New System.Windows.Forms.TextBox()
        Me.Txt_Passoword = New System.Windows.Forms.TextBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Lbl_Cadastro = New System.Windows.Forms.LinkLabel()
        Me.Lbl_AlterarSenha = New System.Windows.Forms.LinkLabel()
        Me.btn_Logar = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(229, 230)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Lbl_Login
        '
        Me.Lbl_Login.Location = New System.Drawing.Point(235, 22)
        Me.Lbl_Login.Name = "Lbl_Login"
        Me.Lbl_Login.Size = New System.Drawing.Size(220, 23)
        Me.Lbl_Login.TabIndex = 0
        Me.Lbl_Login.Text = "&Nome de Usuário"
        Me.Lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Senha
        '
        Me.Lbl_Senha.Location = New System.Drawing.Point(235, 69)
        Me.Lbl_Senha.Name = "Lbl_Senha"
        Me.Lbl_Senha.Size = New System.Drawing.Size(220, 23)
        Me.Lbl_Senha.TabIndex = 2
        Me.Lbl_Senha.Text = "&Senha"
        Me.Lbl_Senha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Login
        '
        Me.Txt_Login.Location = New System.Drawing.Point(237, 42)
        Me.Txt_Login.Name = "Txt_Login"
        Me.Txt_Login.Size = New System.Drawing.Size(220, 20)
        Me.Txt_Login.TabIndex = 1
        '
        'Txt_Passoword
        '
        Me.Txt_Passoword.Location = New System.Drawing.Point(237, 89)
        Me.Txt_Passoword.Name = "Txt_Passoword"
        Me.Txt_Passoword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Passoword.Size = New System.Drawing.Size(220, 20)
        Me.Txt_Passoword.TabIndex = 3
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancelar.Location = New System.Drawing.Point(352, 115)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(94, 23)
        Me.Btn_Cancelar.TabIndex = 5
        Me.Btn_Cancelar.Text = "&Cancelar"
        '
        'Lbl_Cadastro
        '
        Me.Lbl_Cadastro.AutoSize = True
        Me.Lbl_Cadastro.Location = New System.Drawing.Point(235, 187)
        Me.Lbl_Cadastro.Name = "Lbl_Cadastro"
        Me.Lbl_Cadastro.Size = New System.Drawing.Size(59, 13)
        Me.Lbl_Cadastro.TabIndex = 6
        Me.Lbl_Cadastro.TabStop = True
        Me.Lbl_Cadastro.Text = "LinkLabel1"
        '
        'Lbl_AlterarSenha
        '
        Me.Lbl_AlterarSenha.AutoSize = True
        Me.Lbl_AlterarSenha.Location = New System.Drawing.Point(235, 210)
        Me.Lbl_AlterarSenha.Name = "Lbl_AlterarSenha"
        Me.Lbl_AlterarSenha.Size = New System.Drawing.Size(59, 13)
        Me.Lbl_AlterarSenha.TabIndex = 7
        Me.Lbl_AlterarSenha.TabStop = True
        Me.Lbl_AlterarSenha.Text = "LinkLabel2"
        '
        'btn_Logar
        '
        Me.btn_Logar.Location = New System.Drawing.Point(237, 115)
        Me.btn_Logar.Name = "btn_Logar"
        Me.btn_Logar.Size = New System.Drawing.Size(94, 23)
        Me.btn_Logar.TabIndex = 4
        Me.btn_Logar.Text = "&OK"
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Cancelar
        Me.ClientSize = New System.Drawing.Size(484, 232)
        Me.Controls.Add(Me.Lbl_AlterarSenha)
        Me.Controls.Add(Me.Lbl_Cadastro)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.btn_Logar)
        Me.Controls.Add(Me.Txt_Passoword)
        Me.Controls.Add(Me.Txt_Login)
        Me.Controls.Add(Me.Lbl_Senha)
        Me.Controls.Add(Me.Lbl_Login)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm1"
        Me.TransparencyKey = System.Drawing.Color.Navy
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Cadastro As LinkLabel
    Friend WithEvents Lbl_AlterarSenha As LinkLabel
    Friend WithEvents btn_Logar As Button
End Class
