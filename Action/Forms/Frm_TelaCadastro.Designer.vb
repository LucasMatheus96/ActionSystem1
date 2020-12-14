<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaCadastro
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_TelaCadastro))
        Me.Grp_Cadastro = New System.Windows.Forms.GroupBox()
        Me.Txt_ConfirmarSenha = New System.Windows.Forms.TextBox()
        Me.Lbl_ConfirmaSenha = New System.Windows.Forms.Label()
        Me.Txt_Senha = New System.Windows.Forms.TextBox()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Txt_Nome = New System.Windows.Forms.TextBox()
        Me.Lbl_Senha = New System.Windows.Forms.Label()
        Me.Lbl_Usuario = New System.Windows.Forms.Label()
        Me.Lbl_Nome = New System.Windows.Forms.Label()
        Me.Btn_Confirmar = New System.Windows.Forms.Button()
        Me.Grp_Permissao = New System.Windows.Forms.GroupBox()
        Me.CheckBox_Relatorio = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Alterar = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Excluir = New System.Windows.Forms.CheckBox()
        Me.Check_Consulta = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Naosei = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Permissao = New System.Windows.Forms.CheckBox()
        Me.Checkbox_CadastroAtivo = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Administrador = New System.Windows.Forms.CheckBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Grp_Cadastro.SuspendLayout()
        Me.Grp_Permissao.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grp_Cadastro
        '
        Me.Grp_Cadastro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grp_Cadastro.Controls.Add(Me.Txt_ConfirmarSenha)
        Me.Grp_Cadastro.Controls.Add(Me.Lbl_ConfirmaSenha)
        Me.Grp_Cadastro.Controls.Add(Me.Txt_Senha)
        Me.Grp_Cadastro.Controls.Add(Me.Txt_Usuario)
        Me.Grp_Cadastro.Controls.Add(Me.Txt_Nome)
        Me.Grp_Cadastro.Controls.Add(Me.Lbl_Senha)
        Me.Grp_Cadastro.Controls.Add(Me.Lbl_Usuario)
        Me.Grp_Cadastro.Controls.Add(Me.Lbl_Nome)
        Me.Grp_Cadastro.Location = New System.Drawing.Point(163, 12)
        Me.Grp_Cadastro.Name = "Grp_Cadastro"
        Me.Grp_Cadastro.Size = New System.Drawing.Size(463, 241)
        Me.Grp_Cadastro.TabIndex = 0
        Me.Grp_Cadastro.TabStop = False
        Me.Grp_Cadastro.Text = "GroupBox1"
        '
        'Txt_ConfirmarSenha
        '
        Me.Txt_ConfirmarSenha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_ConfirmarSenha.Location = New System.Drawing.Point(23, 202)
        Me.Txt_ConfirmarSenha.Name = "Txt_ConfirmarSenha"
        Me.Txt_ConfirmarSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_ConfirmarSenha.Size = New System.Drawing.Size(400, 20)
        Me.Txt_ConfirmarSenha.TabIndex = 3
        '
        'Lbl_ConfirmaSenha
        '
        Me.Lbl_ConfirmaSenha.AutoSize = True
        Me.Lbl_ConfirmaSenha.Location = New System.Drawing.Point(20, 186)
        Me.Lbl_ConfirmaSenha.Name = "Lbl_ConfirmaSenha"
        Me.Lbl_ConfirmaSenha.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ConfirmaSenha.TabIndex = 7
        Me.Lbl_ConfirmaSenha.Text = "Label3"
        '
        'Txt_Senha
        '
        Me.Txt_Senha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Senha.Location = New System.Drawing.Point(23, 160)
        Me.Txt_Senha.Name = "Txt_Senha"
        Me.Txt_Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Senha.Size = New System.Drawing.Size(400, 20)
        Me.Txt_Senha.TabIndex = 2
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Usuario.Location = New System.Drawing.Point(23, 117)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(400, 20)
        Me.Txt_Usuario.TabIndex = 1
        '
        'Txt_Nome
        '
        Me.Txt_Nome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Nome.Location = New System.Drawing.Point(23, 66)
        Me.Txt_Nome.Name = "Txt_Nome"
        Me.Txt_Nome.Size = New System.Drawing.Size(400, 20)
        Me.Txt_Nome.TabIndex = 0
        '
        'Lbl_Senha
        '
        Me.Lbl_Senha.AutoSize = True
        Me.Lbl_Senha.Location = New System.Drawing.Point(20, 144)
        Me.Lbl_Senha.Name = "Lbl_Senha"
        Me.Lbl_Senha.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Senha.TabIndex = 2
        Me.Lbl_Senha.Text = "Label3"
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Location = New System.Drawing.Point(20, 101)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Usuario.TabIndex = 1
        Me.Lbl_Usuario.Text = "Label2"
        '
        'Lbl_Nome
        '
        Me.Lbl_Nome.AutoSize = True
        Me.Lbl_Nome.Location = New System.Drawing.Point(20, 50)
        Me.Lbl_Nome.Name = "Lbl_Nome"
        Me.Lbl_Nome.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Nome.TabIndex = 0
        Me.Lbl_Nome.Text = "Label1"
        '
        'Btn_Confirmar
        '
        Me.Btn_Confirmar.Location = New System.Drawing.Point(382, 344)
        Me.Btn_Confirmar.Name = "Btn_Confirmar"
        Me.Btn_Confirmar.Size = New System.Drawing.Size(118, 27)
        Me.Btn_Confirmar.TabIndex = 4
        Me.Btn_Confirmar.Text = "Button1"
        Me.Btn_Confirmar.UseVisualStyleBackColor = True
        '
        'Grp_Permissao
        '
        Me.Grp_Permissao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grp_Permissao.Controls.Add(Me.CheckBox_Relatorio)
        Me.Grp_Permissao.Controls.Add(Me.CheckBox_Alterar)
        Me.Grp_Permissao.Controls.Add(Me.CheckBox_Excluir)
        Me.Grp_Permissao.Controls.Add(Me.Check_Consulta)
        Me.Grp_Permissao.Controls.Add(Me.CheckBox_Naosei)
        Me.Grp_Permissao.Controls.Add(Me.CheckBox_Permissao)
        Me.Grp_Permissao.Controls.Add(Me.Checkbox_CadastroAtivo)
        Me.Grp_Permissao.Location = New System.Drawing.Point(163, 259)
        Me.Grp_Permissao.Name = "Grp_Permissao"
        Me.Grp_Permissao.Size = New System.Drawing.Size(463, 83)
        Me.Grp_Permissao.TabIndex = 1
        Me.Grp_Permissao.TabStop = False
        Me.Grp_Permissao.Text = "GroupBox1"
        '
        'CheckBox_Relatorio
        '
        Me.CheckBox_Relatorio.AutoSize = True
        Me.CheckBox_Relatorio.Location = New System.Drawing.Point(213, 42)
        Me.CheckBox_Relatorio.Name = "CheckBox_Relatorio"
        Me.CheckBox_Relatorio.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_Relatorio.TabIndex = 6
        Me.CheckBox_Relatorio.Text = "CheckBox7"
        Me.CheckBox_Relatorio.UseVisualStyleBackColor = True
        '
        'CheckBox_Alterar
        '
        Me.CheckBox_Alterar.AutoSize = True
        Me.CheckBox_Alterar.Location = New System.Drawing.Point(126, 19)
        Me.CheckBox_Alterar.Name = "CheckBox_Alterar"
        Me.CheckBox_Alterar.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_Alterar.TabIndex = 1
        Me.CheckBox_Alterar.Text = "CheckBox6"
        Me.CheckBox_Alterar.UseVisualStyleBackColor = True
        '
        'CheckBox_Excluir
        '
        Me.CheckBox_Excluir.AutoSize = True
        Me.CheckBox_Excluir.Location = New System.Drawing.Point(126, 42)
        Me.CheckBox_Excluir.Name = "CheckBox_Excluir"
        Me.CheckBox_Excluir.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_Excluir.TabIndex = 5
        Me.CheckBox_Excluir.Text = "CheckBox5"
        Me.CheckBox_Excluir.UseVisualStyleBackColor = True
        '
        'Check_Consulta
        '
        Me.Check_Consulta.AutoSize = True
        Me.Check_Consulta.Location = New System.Drawing.Point(23, 42)
        Me.Check_Consulta.Name = "Check_Consulta"
        Me.Check_Consulta.Size = New System.Drawing.Size(81, 17)
        Me.Check_Consulta.TabIndex = 4
        Me.Check_Consulta.Text = "CheckBox4"
        Me.Check_Consulta.UseVisualStyleBackColor = True
        '
        'CheckBox_Naosei
        '
        Me.CheckBox_Naosei.AutoSize = True
        Me.CheckBox_Naosei.Location = New System.Drawing.Point(300, 19)
        Me.CheckBox_Naosei.Name = "CheckBox_Naosei"
        Me.CheckBox_Naosei.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_Naosei.TabIndex = 3
        Me.CheckBox_Naosei.Text = "CheckBox3"
        Me.CheckBox_Naosei.UseVisualStyleBackColor = True
        '
        'CheckBox_Permissao
        '
        Me.CheckBox_Permissao.AutoSize = True
        Me.CheckBox_Permissao.Location = New System.Drawing.Point(213, 19)
        Me.CheckBox_Permissao.Name = "CheckBox_Permissao"
        Me.CheckBox_Permissao.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_Permissao.TabIndex = 2
        Me.CheckBox_Permissao.Text = "CheckBox2"
        Me.CheckBox_Permissao.UseVisualStyleBackColor = True
        '
        'Checkbox_CadastroAtivo
        '
        Me.Checkbox_CadastroAtivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Checkbox_CadastroAtivo.AutoSize = True
        Me.Checkbox_CadastroAtivo.Location = New System.Drawing.Point(23, 19)
        Me.Checkbox_CadastroAtivo.Name = "Checkbox_CadastroAtivo"
        Me.Checkbox_CadastroAtivo.Size = New System.Drawing.Size(81, 17)
        Me.Checkbox_CadastroAtivo.TabIndex = 0
        Me.Checkbox_CadastroAtivo.Text = "CheckBox1"
        Me.Checkbox_CadastroAtivo.UseVisualStyleBackColor = True
        '
        'CheckBox_Administrador
        '
        Me.CheckBox_Administrador.AutoSize = True
        Me.CheckBox_Administrador.Location = New System.Drawing.Point(177, 348)
        Me.CheckBox_Administrador.Name = "CheckBox_Administrador"
        Me.CheckBox_Administrador.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_Administrador.TabIndex = 3
        Me.CheckBox_Administrador.Text = "CheckBox8"
        Me.CheckBox_Administrador.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(506, 344)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(120, 27)
        Me.Btn_Cancelar.TabIndex = 5
        Me.Btn_Cancelar.Text = "Button2"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 96)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Frm_TelaCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 408)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.CheckBox_Administrador)
        Me.Controls.Add(Me.Grp_Permissao)
        Me.Controls.Add(Me.Btn_Confirmar)
        Me.Controls.Add(Me.Grp_Cadastro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_TelaCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_TelaCadastro"
        Me.Grp_Cadastro.ResumeLayout(False)
        Me.Grp_Cadastro.PerformLayout()
        Me.Grp_Permissao.ResumeLayout(False)
        Me.Grp_Permissao.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grp_Cadastro As GroupBox
    Friend WithEvents Txt_Senha As TextBox
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents Txt_Nome As TextBox
    Friend WithEvents Lbl_Senha As Label
    Friend WithEvents Lbl_Usuario As Label
    Friend WithEvents Lbl_Nome As Label
    Friend WithEvents Btn_Confirmar As Button
    Friend WithEvents Grp_Permissao As GroupBox
    Friend WithEvents CheckBox_Administrador As CheckBox
    Friend WithEvents CheckBox_Relatorio As CheckBox
    Friend WithEvents CheckBox_Alterar As CheckBox
    Friend WithEvents CheckBox_Excluir As CheckBox
    Friend WithEvents Check_Consulta As CheckBox
    Friend WithEvents CheckBox_Naosei As CheckBox
    Friend WithEvents CheckBox_Permissao As CheckBox
    Friend WithEvents Checkbox_CadastroAtivo As CheckBox
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txt_ConfirmarSenha As TextBox
    Friend WithEvents Lbl_ConfirmaSenha As Label
End Class
