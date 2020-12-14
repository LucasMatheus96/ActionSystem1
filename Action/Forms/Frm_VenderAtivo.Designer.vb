<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_VenderAtivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_VenderAtivo))
        Me.Grb_VendaAtivos = New System.Windows.Forms.GroupBox()
        Me.Txt_PosicaoAtual = New System.Windows.Forms.TextBox()
        Me.lbl_PosicaoAtual = New System.Windows.Forms.Label()
        Me.Txt_TotalVenda = New System.Windows.Forms.TextBox()
        Me.Lbl_TotalVenda = New System.Windows.Forms.Label()
        Me.Btn_Vender = New System.Windows.Forms.Button()
        Me.Txt_PrecoVenda = New System.Windows.Forms.TextBox()
        Me.Lbl_PreçoVenda = New System.Windows.Forms.Label()
        Me.lbl_Ativo = New System.Windows.Forms.Label()
        Me.Txt_Ativo = New System.Windows.Forms.TextBox()
        Me.Txt_QuantidadeDisponivel = New System.Windows.Forms.TextBox()
        Me.lbl_quantidadeDisponivel = New System.Windows.Forms.Label()
        Me.Txt_quantidadeVenda = New System.Windows.Forms.TextBox()
        Me.Lbl_Quantidade = New System.Windows.Forms.Label()
        Me.Grb_VendaAtivos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grb_VendaAtivos
        '
        Me.Grb_VendaAtivos.Controls.Add(Me.Txt_PosicaoAtual)
        Me.Grb_VendaAtivos.Controls.Add(Me.lbl_PosicaoAtual)
        Me.Grb_VendaAtivos.Controls.Add(Me.Txt_TotalVenda)
        Me.Grb_VendaAtivos.Controls.Add(Me.Lbl_TotalVenda)
        Me.Grb_VendaAtivos.Controls.Add(Me.Btn_Vender)
        Me.Grb_VendaAtivos.Controls.Add(Me.Txt_PrecoVenda)
        Me.Grb_VendaAtivos.Controls.Add(Me.Lbl_PreçoVenda)
        Me.Grb_VendaAtivos.Controls.Add(Me.lbl_Ativo)
        Me.Grb_VendaAtivos.Controls.Add(Me.Txt_Ativo)
        Me.Grb_VendaAtivos.Controls.Add(Me.Txt_QuantidadeDisponivel)
        Me.Grb_VendaAtivos.Controls.Add(Me.lbl_quantidadeDisponivel)
        Me.Grb_VendaAtivos.Controls.Add(Me.Txt_quantidadeVenda)
        Me.Grb_VendaAtivos.Controls.Add(Me.Lbl_Quantidade)
        Me.Grb_VendaAtivos.Location = New System.Drawing.Point(21, 27)
        Me.Grb_VendaAtivos.Name = "Grb_VendaAtivos"
        Me.Grb_VendaAtivos.Size = New System.Drawing.Size(526, 135)
        Me.Grb_VendaAtivos.TabIndex = 0
        Me.Grb_VendaAtivos.TabStop = False
        Me.Grb_VendaAtivos.Text = "Vendendo ativos"
        '
        'Txt_PosicaoAtual
        '
        Me.Txt_PosicaoAtual.Location = New System.Drawing.Point(212, 47)
        Me.Txt_PosicaoAtual.Name = "Txt_PosicaoAtual"
        Me.Txt_PosicaoAtual.Size = New System.Drawing.Size(68, 20)
        Me.Txt_PosicaoAtual.TabIndex = 0
        '
        'lbl_PosicaoAtual
        '
        Me.lbl_PosicaoAtual.AutoSize = True
        Me.lbl_PosicaoAtual.Location = New System.Drawing.Point(209, 31)
        Me.lbl_PosicaoAtual.Name = "lbl_PosicaoAtual"
        Me.lbl_PosicaoAtual.Size = New System.Drawing.Size(71, 13)
        Me.lbl_PosicaoAtual.TabIndex = 11
        Me.lbl_PosicaoAtual.Text = "Posição atual"
        '
        'Txt_TotalVenda
        '
        Me.Txt_TotalVenda.Location = New System.Drawing.Point(437, 47)
        Me.Txt_TotalVenda.Name = "Txt_TotalVenda"
        Me.Txt_TotalVenda.Size = New System.Drawing.Size(80, 20)
        Me.Txt_TotalVenda.TabIndex = 10
        '
        'Lbl_TotalVenda
        '
        Me.Lbl_TotalVenda.AutoSize = True
        Me.Lbl_TotalVenda.Location = New System.Drawing.Point(434, 31)
        Me.Lbl_TotalVenda.Name = "Lbl_TotalVenda"
        Me.Lbl_TotalVenda.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_TotalVenda.TabIndex = 9
        Me.Lbl_TotalVenda.Text = "Total Venda"
        '
        'Btn_Vender
        '
        Me.Btn_Vender.Location = New System.Drawing.Point(6, 100)
        Me.Btn_Vender.Name = "Btn_Vender"
        Me.Btn_Vender.Size = New System.Drawing.Size(511, 23)
        Me.Btn_Vender.TabIndex = 8
        Me.Btn_Vender.Text = "Vender"
        Me.Btn_Vender.UseVisualStyleBackColor = True
        '
        'Txt_PrecoVenda
        '
        Me.Txt_PrecoVenda.Location = New System.Drawing.Point(297, 47)
        Me.Txt_PrecoVenda.Name = "Txt_PrecoVenda"
        Me.Txt_PrecoVenda.Size = New System.Drawing.Size(59, 20)
        Me.Txt_PrecoVenda.TabIndex = 0
        '
        'Lbl_PreçoVenda
        '
        Me.Lbl_PreçoVenda.AutoSize = True
        Me.Lbl_PreçoVenda.Location = New System.Drawing.Point(294, 31)
        Me.Lbl_PreçoVenda.Name = "Lbl_PreçoVenda"
        Me.Lbl_PreçoVenda.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_PreçoVenda.TabIndex = 6
        Me.Lbl_PreçoVenda.Text = "PreçoVenda"
        '
        'lbl_Ativo
        '
        Me.lbl_Ativo.AutoSize = True
        Me.lbl_Ativo.Location = New System.Drawing.Point(3, 31)
        Me.lbl_Ativo.Name = "lbl_Ativo"
        Me.lbl_Ativo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Ativo.TabIndex = 5
        Me.lbl_Ativo.Text = "Ativo"
        '
        'Txt_Ativo
        '
        Me.Txt_Ativo.Location = New System.Drawing.Point(6, 47)
        Me.Txt_Ativo.Name = "Txt_Ativo"
        Me.Txt_Ativo.Size = New System.Drawing.Size(73, 20)
        Me.Txt_Ativo.TabIndex = 4
        '
        'Txt_QuantidadeDisponivel
        '
        Me.Txt_QuantidadeDisponivel.Location = New System.Drawing.Point(93, 47)
        Me.Txt_QuantidadeDisponivel.Name = "Txt_QuantidadeDisponivel"
        Me.Txt_QuantidadeDisponivel.Size = New System.Drawing.Size(100, 20)
        Me.Txt_QuantidadeDisponivel.TabIndex = 3
        '
        'lbl_quantidadeDisponivel
        '
        Me.lbl_quantidadeDisponivel.AutoSize = True
        Me.lbl_quantidadeDisponivel.Location = New System.Drawing.Point(90, 31)
        Me.lbl_quantidadeDisponivel.Name = "lbl_quantidadeDisponivel"
        Me.lbl_quantidadeDisponivel.Size = New System.Drawing.Size(115, 13)
        Me.lbl_quantidadeDisponivel.TabIndex = 2
        Me.lbl_quantidadeDisponivel.Text = "Quantidade disponivel "
        '
        'Txt_quantidadeVenda
        '
        Me.Txt_quantidadeVenda.Location = New System.Drawing.Point(375, 47)
        Me.Txt_quantidadeVenda.Name = "Txt_quantidadeVenda"
        Me.Txt_quantidadeVenda.Size = New System.Drawing.Size(42, 20)
        Me.Txt_quantidadeVenda.TabIndex = 2
        '
        'Lbl_Quantidade
        '
        Me.Lbl_Quantidade.AutoSize = True
        Me.Lbl_Quantidade.Location = New System.Drawing.Point(367, 31)
        Me.Lbl_Quantidade.Name = "Lbl_Quantidade"
        Me.Lbl_Quantidade.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_Quantidade.TabIndex = 0
        Me.Lbl_Quantidade.Text = "Quantidade"
        '
        'Frm_VenderAtivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 182)
        Me.Controls.Add(Me.Grb_VendaAtivos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_VenderAtivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_VenderAtivo"
        Me.Grb_VendaAtivos.ResumeLayout(False)
        Me.Grb_VendaAtivos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grb_VendaAtivos As GroupBox
    Friend WithEvents Txt_TotalVenda As TextBox
    Friend WithEvents Lbl_TotalVenda As Label
    Friend WithEvents Btn_Vender As Button
    Friend WithEvents Txt_PrecoVenda As TextBox
    Friend WithEvents Lbl_PreçoVenda As Label
    Friend WithEvents lbl_Ativo As Label
    Friend WithEvents Txt_Ativo As TextBox
    Friend WithEvents Txt_QuantidadeDisponivel As TextBox
    Friend WithEvents lbl_quantidadeDisponivel As Label
    Friend WithEvents Txt_quantidadeVenda As TextBox
    Friend WithEvents Lbl_Quantidade As Label
    Friend WithEvents Txt_PosicaoAtual As TextBox
    Friend WithEvents lbl_PosicaoAtual As Label
End Class
