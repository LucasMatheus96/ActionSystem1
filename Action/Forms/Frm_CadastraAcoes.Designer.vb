<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_CadastraAcoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadastraAcoes))
        Me.Grp_CadastroAcao = New System.Windows.Forms.GroupBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Limpar = New System.Windows.Forms.Button()
        Me.Btn_Cadastrar = New System.Windows.Forms.Button()
        Me.Lbl_TipoAcao = New System.Windows.Forms.Label()
        Me.Cmb_Tipoacao = New System.Windows.Forms.ComboBox()
        Me.Txt_SetorAtivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Sigla = New System.Windows.Forms.TextBox()
        Me.Lbl_SiglaAtivo = New System.Windows.Forms.Label()
        Me.txt_NomeEmpresa = New System.Windows.Forms.TextBox()
        Me.Lbl_NomeAtivo = New System.Windows.Forms.Label()
        Me.Grp_CadastroAcao.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grp_CadastroAcao
        '
        Me.Grp_CadastroAcao.Controls.Add(Me.Btn_Cancelar)
        Me.Grp_CadastroAcao.Controls.Add(Me.Btn_Limpar)
        Me.Grp_CadastroAcao.Controls.Add(Me.Btn_Cadastrar)
        Me.Grp_CadastroAcao.Controls.Add(Me.Lbl_TipoAcao)
        Me.Grp_CadastroAcao.Controls.Add(Me.Cmb_Tipoacao)
        Me.Grp_CadastroAcao.Controls.Add(Me.Txt_SetorAtivo)
        Me.Grp_CadastroAcao.Controls.Add(Me.Label1)
        Me.Grp_CadastroAcao.Controls.Add(Me.Txt_Sigla)
        Me.Grp_CadastroAcao.Controls.Add(Me.Lbl_SiglaAtivo)
        Me.Grp_CadastroAcao.Controls.Add(Me.txt_NomeEmpresa)
        Me.Grp_CadastroAcao.Controls.Add(Me.Lbl_NomeAtivo)
        Me.Grp_CadastroAcao.Location = New System.Drawing.Point(26, 37)
        Me.Grp_CadastroAcao.Name = "Grp_CadastroAcao"
        Me.Grp_CadastroAcao.Size = New System.Drawing.Size(349, 335)
        Me.Grp_CadastroAcao.TabIndex = 0
        Me.Grp_CadastroAcao.TabStop = False
        Me.Grp_CadastroAcao.Text = "Cadastrando ação"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(170, 270)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(109, 23)
        Me.Btn_Cancelar.TabIndex = 11
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Limpar
        '
        Me.Btn_Limpar.Location = New System.Drawing.Point(65, 270)
        Me.Btn_Limpar.Name = "Btn_Limpar"
        Me.Btn_Limpar.Size = New System.Drawing.Size(99, 23)
        Me.Btn_Limpar.TabIndex = 10
        Me.Btn_Limpar.Text = "Limpar"
        Me.Btn_Limpar.UseVisualStyleBackColor = True
        '
        'Btn_Cadastrar
        '
        Me.Btn_Cadastrar.Location = New System.Drawing.Point(97, 207)
        Me.Btn_Cadastrar.Name = "Btn_Cadastrar"
        Me.Btn_Cadastrar.Size = New System.Drawing.Size(133, 57)
        Me.Btn_Cadastrar.TabIndex = 9
        Me.Btn_Cadastrar.Text = "Cadastrar"
        Me.Btn_Cadastrar.UseVisualStyleBackColor = True
        '
        'Lbl_TipoAcao
        '
        Me.Lbl_TipoAcao.AutoSize = True
        Me.Lbl_TipoAcao.Location = New System.Drawing.Point(184, 149)
        Me.Lbl_TipoAcao.Name = "Lbl_TipoAcao"
        Me.Lbl_TipoAcao.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_TipoAcao.TabIndex = 7
        Me.Lbl_TipoAcao.Text = "Tipo Ação: "
        '
        'Cmb_Tipoacao
        '
        Me.Cmb_Tipoacao.FormattingEnabled = True
        Me.Cmb_Tipoacao.Location = New System.Drawing.Point(187, 165)
        Me.Cmb_Tipoacao.Name = "Cmb_Tipoacao"
        Me.Cmb_Tipoacao.Size = New System.Drawing.Size(118, 21)
        Me.Cmb_Tipoacao.TabIndex = 6
        '
        'Txt_SetorAtivo
        '
        Me.Txt_SetorAtivo.Location = New System.Drawing.Point(32, 114)
        Me.Txt_SetorAtivo.Name = "Txt_SetorAtivo"
        Me.Txt_SetorAtivo.Size = New System.Drawing.Size(273, 20)
        Me.Txt_SetorAtivo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Setor Ativo"
        '
        'Txt_Sigla
        '
        Me.Txt_Sigla.Location = New System.Drawing.Point(34, 165)
        Me.Txt_Sigla.Name = "Txt_Sigla"
        Me.Txt_Sigla.Size = New System.Drawing.Size(93, 20)
        Me.Txt_Sigla.TabIndex = 3
        '
        'Lbl_SiglaAtivo
        '
        Me.Lbl_SiglaAtivo.AutoSize = True
        Me.Lbl_SiglaAtivo.Location = New System.Drawing.Point(31, 149)
        Me.Lbl_SiglaAtivo.Name = "Lbl_SiglaAtivo"
        Me.Lbl_SiglaAtivo.Size = New System.Drawing.Size(33, 13)
        Me.Lbl_SiglaAtivo.TabIndex = 2
        Me.Lbl_SiglaAtivo.Text = "Sigla:"
        '
        'txt_NomeEmpresa
        '
        Me.txt_NomeEmpresa.Location = New System.Drawing.Point(32, 60)
        Me.txt_NomeEmpresa.Name = "txt_NomeEmpresa"
        Me.txt_NomeEmpresa.Size = New System.Drawing.Size(273, 20)
        Me.txt_NomeEmpresa.TabIndex = 1
        '
        'Lbl_NomeAtivo
        '
        Me.Lbl_NomeAtivo.AutoSize = True
        Me.Lbl_NomeAtivo.Location = New System.Drawing.Point(29, 44)
        Me.Lbl_NomeAtivo.Name = "Lbl_NomeAtivo"
        Me.Lbl_NomeAtivo.Size = New System.Drawing.Size(96, 13)
        Me.Lbl_NomeAtivo.TabIndex = 0
        Me.Lbl_NomeAtivo.Text = "Nome da empresa:"
        '
        'Frm_CadastraAcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 381)
        Me.Controls.Add(Me.Grp_CadastroAcao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_CadastraAcoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_CadastraAcoes"
        Me.Grp_CadastroAcao.ResumeLayout(False)
        Me.Grp_CadastroAcao.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grp_CadastroAcao As GroupBox
    Friend WithEvents Txt_SetorAtivo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Sigla As TextBox
    Friend WithEvents Lbl_SiglaAtivo As Label
    Friend WithEvents txt_NomeEmpresa As TextBox
    Friend WithEvents Lbl_NomeAtivo As Label
    Friend WithEvents Lbl_TipoAcao As Label
    Friend WithEvents Cmb_Tipoacao As ComboBox
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Limpar As Button
    Friend WithEvents Btn_Cadastrar As Button
End Class
