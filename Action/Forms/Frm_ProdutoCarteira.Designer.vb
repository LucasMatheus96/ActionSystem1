<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ProdutoCarteira
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ProdutoCarteira))
        Me.Grb_Adicionar = New System.Windows.Forms.GroupBox()
        Me.Txt_descricao = New System.Windows.Forms.TextBox()
        Me.Lbl_InstituiçãoFinanceira = New System.Windows.Forms.Label()
        Me.Lbl_TotalAplicado = New System.Windows.Forms.Label()
        Me.Txt_TotalAplicado = New System.Windows.Forms.TextBox()
        Me.Btn_Adicionar = New System.Windows.Forms.Button()
        Me.Lbl_Precomedio = New System.Windows.Forms.Label()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.Cmb_Ativo = New System.Windows.Forms.ComboBox()
        Me.Lbl_SiglaAtivo = New System.Windows.Forms.Label()
        Me.Lbl_Quantidade = New System.Windows.Forms.Label()
        Me.Txt_quantidade = New System.Windows.Forms.TextBox()
        Me.Cmb_TipoAtivo = New System.Windows.Forms.ComboBox()
        Me.Lbl_TipoAtivo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_NomeCarteira = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Grb_Adicionar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grb_Adicionar
        '
        Me.Grb_Adicionar.Controls.Add(Me.Txt_descricao)
        Me.Grb_Adicionar.Controls.Add(Me.Lbl_InstituiçãoFinanceira)
        Me.Grb_Adicionar.Controls.Add(Me.Lbl_TotalAplicado)
        Me.Grb_Adicionar.Controls.Add(Me.Txt_TotalAplicado)
        Me.Grb_Adicionar.Controls.Add(Me.Btn_Adicionar)
        Me.Grb_Adicionar.Controls.Add(Me.Lbl_Precomedio)
        Me.Grb_Adicionar.Controls.Add(Me.txt_preco)
        Me.Grb_Adicionar.Controls.Add(Me.Cmb_Ativo)
        Me.Grb_Adicionar.Controls.Add(Me.Lbl_SiglaAtivo)
        Me.Grb_Adicionar.Controls.Add(Me.Lbl_Quantidade)
        Me.Grb_Adicionar.Controls.Add(Me.Txt_quantidade)
        Me.Grb_Adicionar.Controls.Add(Me.Cmb_TipoAtivo)
        Me.Grb_Adicionar.Controls.Add(Me.Lbl_TipoAtivo)
        Me.Grb_Adicionar.Controls.Add(Me.Label1)
        Me.Grb_Adicionar.Controls.Add(Me.Cmb_NomeCarteira)
        Me.Grb_Adicionar.Location = New System.Drawing.Point(12, 26)
        Me.Grb_Adicionar.Name = "Grb_Adicionar"
        Me.Grb_Adicionar.Size = New System.Drawing.Size(533, 223)
        Me.Grb_Adicionar.TabIndex = 0
        Me.Grb_Adicionar.TabStop = False
        Me.Grb_Adicionar.Text = "Adicionando ativo na carteira"
        '
        'Txt_descricao
        '
        Me.Txt_descricao.Location = New System.Drawing.Point(13, 32)
        Me.Txt_descricao.Name = "Txt_descricao"
        Me.Txt_descricao.Size = New System.Drawing.Size(500, 20)
        Me.Txt_descricao.TabIndex = 15
        '
        'Lbl_InstituiçãoFinanceira
        '
        Me.Lbl_InstituiçãoFinanceira.AutoSize = True
        Me.Lbl_InstituiçãoFinanceira.Location = New System.Drawing.Point(14, 16)
        Me.Lbl_InstituiçãoFinanceira.Name = "Lbl_InstituiçãoFinanceira"
        Me.Lbl_InstituiçãoFinanceira.Size = New System.Drawing.Size(107, 13)
        Me.Lbl_InstituiçãoFinanceira.TabIndex = 14
        Me.Lbl_InstituiçãoFinanceira.Text = "Instituição Financeira"
        '
        'Lbl_TotalAplicado
        '
        Me.Lbl_TotalAplicado.AutoSize = True
        Me.Lbl_TotalAplicado.Location = New System.Drawing.Point(364, 136)
        Me.Lbl_TotalAplicado.Name = "Lbl_TotalAplicado"
        Me.Lbl_TotalAplicado.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_TotalAplicado.TabIndex = 12
        Me.Lbl_TotalAplicado.Text = "Total"
        '
        'Txt_TotalAplicado
        '
        Me.Txt_TotalAplicado.Location = New System.Drawing.Point(367, 152)
        Me.Txt_TotalAplicado.Name = "Txt_TotalAplicado"
        Me.Txt_TotalAplicado.Size = New System.Drawing.Size(92, 20)
        Me.Txt_TotalAplicado.TabIndex = 11
        '
        'Btn_Adicionar
        '
        Me.Btn_Adicionar.Location = New System.Drawing.Point(15, 186)
        Me.Btn_Adicionar.Name = "Btn_Adicionar"
        Me.Btn_Adicionar.Size = New System.Drawing.Size(500, 23)
        Me.Btn_Adicionar.TabIndex = 10
        Me.Btn_Adicionar.Text = "Adicionar"
        Me.Btn_Adicionar.UseVisualStyleBackColor = True
        '
        'Lbl_Precomedio
        '
        Me.Lbl_Precomedio.AutoSize = True
        Me.Lbl_Precomedio.Location = New System.Drawing.Point(12, 138)
        Me.Lbl_Precomedio.Name = "Lbl_Precomedio"
        Me.Lbl_Precomedio.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_Precomedio.TabIndex = 9
        Me.Lbl_Precomedio.Text = "Preço"
        '
        'txt_preco
        '
        Me.txt_preco.Location = New System.Drawing.Point(15, 154)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(110, 20)
        Me.txt_preco.TabIndex = 8
        '
        'Cmb_Ativo
        '
        Me.Cmb_Ativo.FormattingEnabled = True
        Me.Cmb_Ativo.Location = New System.Drawing.Point(366, 70)
        Me.Cmb_Ativo.Name = "Cmb_Ativo"
        Me.Cmb_Ativo.Size = New System.Drawing.Size(149, 21)
        Me.Cmb_Ativo.TabIndex = 7
        '
        'Lbl_SiglaAtivo
        '
        Me.Lbl_SiglaAtivo.AutoSize = True
        Me.Lbl_SiglaAtivo.Location = New System.Drawing.Point(363, 54)
        Me.Lbl_SiglaAtivo.Name = "Lbl_SiglaAtivo"
        Me.Lbl_SiglaAtivo.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_SiglaAtivo.TabIndex = 6
        Me.Lbl_SiglaAtivo.Text = "Ativo"
        '
        'Lbl_Quantidade
        '
        Me.Lbl_Quantidade.AutoSize = True
        Me.Lbl_Quantidade.Location = New System.Drawing.Point(186, 138)
        Me.Lbl_Quantidade.Name = "Lbl_Quantidade"
        Me.Lbl_Quantidade.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_Quantidade.TabIndex = 5
        Me.Lbl_Quantidade.Text = "Quantidade"
        '
        'Txt_quantidade
        '
        Me.Txt_quantidade.Location = New System.Drawing.Point(189, 154)
        Me.Txt_quantidade.Name = "Txt_quantidade"
        Me.Txt_quantidade.Size = New System.Drawing.Size(59, 20)
        Me.Txt_quantidade.TabIndex = 4
        '
        'Cmb_TipoAtivo
        '
        Me.Cmb_TipoAtivo.FormattingEnabled = True
        Me.Cmb_TipoAtivo.Location = New System.Drawing.Point(189, 70)
        Me.Cmb_TipoAtivo.Name = "Cmb_TipoAtivo"
        Me.Cmb_TipoAtivo.Size = New System.Drawing.Size(149, 21)
        Me.Cmb_TipoAtivo.TabIndex = 3
        '
        'Lbl_TipoAtivo
        '
        Me.Lbl_TipoAtivo.AutoSize = True
        Me.Lbl_TipoAtivo.Location = New System.Drawing.Point(186, 54)
        Me.Lbl_TipoAtivo.Name = "Lbl_TipoAtivo"
        Me.Lbl_TipoAtivo.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_TipoAtivo.TabIndex = 2
        Me.Lbl_TipoAtivo.Text = "Tipo Ativo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Carteira"
        '
        'Cmb_NomeCarteira
        '
        Me.Cmb_NomeCarteira.FormattingEnabled = True
        Me.Cmb_NomeCarteira.Location = New System.Drawing.Point(15, 70)
        Me.Cmb_NomeCarteira.Name = "Cmb_NomeCarteira"
        Me.Cmb_NomeCarteira.Size = New System.Drawing.Size(149, 21)
        Me.Cmb_NomeCarteira.TabIndex = 0
        '
        'Frm_ProdutoCarteira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 530)
        Me.Controls.Add(Me.Grb_Adicionar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ProdutoCarteira"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ProdutoCarteira"
        Me.Grb_Adicionar.ResumeLayout(False)
        Me.Grb_Adicionar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grb_Adicionar As GroupBox
    Friend WithEvents Btn_Adicionar As Button
    Friend WithEvents Lbl_Precomedio As Label
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents Cmb_Ativo As ComboBox
    Friend WithEvents Lbl_SiglaAtivo As Label
    Friend WithEvents Lbl_Quantidade As Label
    Friend WithEvents Txt_quantidade As TextBox
    Friend WithEvents Cmb_TipoAtivo As ComboBox
    Friend WithEvents Lbl_TipoAtivo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_NomeCarteira As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Lbl_TotalAplicado As Label
    Friend WithEvents Txt_TotalAplicado As TextBox
    Friend WithEvents Lbl_InstituiçãoFinanceira As Label
    Friend WithEvents Txt_descricao As TextBox
End Class
