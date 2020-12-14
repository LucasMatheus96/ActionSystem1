<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CadastraRendaFixa
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadastraRendaFixa))
        Me.Lbl_NomeTitulo = New System.Windows.Forms.Label()
        Me.Grb_RendaFixa = New System.Windows.Forms.GroupBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Limpar = New System.Windows.Forms.Button()
        Me.Btn_Cadastrar = New System.Windows.Forms.Button()
        Me.TxT_RentabilidadeTitulo = New System.Windows.Forms.TextBox()
        Me.Lbl_Rentabilidade = New System.Windows.Forms.Label()
        Me.Cmb_TipoTitulo = New System.Windows.Forms.ComboBox()
        Me.lbl_TipoRendaFixa = New System.Windows.Forms.Label()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.Grb_RendaFixa.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_NomeTitulo
        '
        Me.Lbl_NomeTitulo.AutoSize = True
        Me.Lbl_NomeTitulo.Location = New System.Drawing.Point(24, 42)
        Me.Lbl_NomeTitulo.Name = "Lbl_NomeTitulo"
        Me.Lbl_NomeTitulo.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_NomeTitulo.TabIndex = 0
        Me.Lbl_NomeTitulo.Text = "Nome do titulo"
        '
        'Grb_RendaFixa
        '
        Me.Grb_RendaFixa.Controls.Add(Me.Btn_Cancelar)
        Me.Grb_RendaFixa.Controls.Add(Me.Btn_Limpar)
        Me.Grb_RendaFixa.Controls.Add(Me.Btn_Cadastrar)
        Me.Grb_RendaFixa.Controls.Add(Me.TxT_RentabilidadeTitulo)
        Me.Grb_RendaFixa.Controls.Add(Me.Lbl_Rentabilidade)
        Me.Grb_RendaFixa.Controls.Add(Me.Cmb_TipoTitulo)
        Me.Grb_RendaFixa.Controls.Add(Me.lbl_TipoRendaFixa)
        Me.Grb_RendaFixa.Controls.Add(Me.txt_titulo)
        Me.Grb_RendaFixa.Controls.Add(Me.Lbl_NomeTitulo)
        Me.Grb_RendaFixa.Location = New System.Drawing.Point(25, 24)
        Me.Grb_RendaFixa.Name = "Grb_RendaFixa"
        Me.Grb_RendaFixa.Size = New System.Drawing.Size(349, 335)
        Me.Grb_RendaFixa.TabIndex = 0
        Me.Grb_RendaFixa.TabStop = False
        Me.Grb_RendaFixa.Text = "Cadastrando o ativo"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(170, 261)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(126, 33)
        Me.Btn_Cancelar.TabIndex = 8
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Limpar
        '
        Me.Btn_Limpar.Location = New System.Drawing.Point(39, 261)
        Me.Btn_Limpar.Name = "Btn_Limpar"
        Me.Btn_Limpar.Size = New System.Drawing.Size(118, 33)
        Me.Btn_Limpar.TabIndex = 7
        Me.Btn_Limpar.Text = "Limpar"
        Me.Btn_Limpar.UseVisualStyleBackColor = True
        '
        'Btn_Cadastrar
        '
        Me.Btn_Cadastrar.Location = New System.Drawing.Point(66, 198)
        Me.Btn_Cadastrar.Name = "Btn_Cadastrar"
        Me.Btn_Cadastrar.Size = New System.Drawing.Size(195, 57)
        Me.Btn_Cadastrar.TabIndex = 6
        Me.Btn_Cadastrar.Text = "Cadastrar"
        Me.Btn_Cadastrar.UseVisualStyleBackColor = True
        '
        'TxT_RentabilidadeTitulo
        '
        Me.TxT_RentabilidadeTitulo.Location = New System.Drawing.Point(27, 165)
        Me.TxT_RentabilidadeTitulo.Name = "TxT_RentabilidadeTitulo"
        Me.TxT_RentabilidadeTitulo.Size = New System.Drawing.Size(65, 20)
        Me.TxT_RentabilidadeTitulo.TabIndex = 5
        '
        'Lbl_Rentabilidade
        '
        Me.Lbl_Rentabilidade.AutoSize = True
        Me.Lbl_Rentabilidade.Location = New System.Drawing.Point(24, 149)
        Me.Lbl_Rentabilidade.Name = "Lbl_Rentabilidade"
        Me.Lbl_Rentabilidade.Size = New System.Drawing.Size(133, 13)
        Me.Lbl_Rentabilidade.TabIndex = 4
        Me.Lbl_Rentabilidade.Text = "Rentabilidade do Titulo (%)"
        '
        'Cmb_TipoTitulo
        '
        Me.Cmb_TipoTitulo.FormattingEnabled = True
        Me.Cmb_TipoTitulo.Location = New System.Drawing.Point(27, 112)
        Me.Cmb_TipoTitulo.Name = "Cmb_TipoTitulo"
        Me.Cmb_TipoTitulo.Size = New System.Drawing.Size(269, 21)
        Me.Cmb_TipoTitulo.TabIndex = 3
        '
        'lbl_TipoRendaFixa
        '
        Me.lbl_TipoRendaFixa.AutoSize = True
        Me.lbl_TipoRendaFixa.Location = New System.Drawing.Point(24, 96)
        Me.lbl_TipoRendaFixa.Name = "lbl_TipoRendaFixa"
        Me.lbl_TipoRendaFixa.Size = New System.Drawing.Size(68, 13)
        Me.lbl_TipoRendaFixa.TabIndex = 2
        Me.lbl_TipoRendaFixa.Text = "Tipo de titulo"
        '
        'txt_titulo
        '
        Me.txt_titulo.Location = New System.Drawing.Point(27, 58)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(269, 20)
        Me.txt_titulo.TabIndex = 1
        '
        'Frm_CadastraRendaFixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 381)
        Me.Controls.Add(Me.Grb_RendaFixa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_CadastraRendaFixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_CadastraRendaFixa"
        Me.Grb_RendaFixa.ResumeLayout(False)
        Me.Grb_RendaFixa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_NomeTitulo As Label
    Friend WithEvents Grb_RendaFixa As GroupBox
    Friend WithEvents Btn_Limpar As Button
    Friend WithEvents Btn_Cadastrar As Button
    Friend WithEvents TxT_RentabilidadeTitulo As TextBox
    Friend WithEvents Lbl_Rentabilidade As Label
    Friend WithEvents Cmb_TipoTitulo As ComboBox
    Friend WithEvents lbl_TipoRendaFixa As Label
    Friend WithEvents txt_titulo As TextBox
    Friend WithEvents Btn_Cancelar As Button
End Class
