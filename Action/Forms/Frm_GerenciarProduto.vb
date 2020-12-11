Imports Action.Classes
Imports Action.Controller

Public Class Frm_GerenciarProduto
    Dim controlInvestimento As New ControladorInvestimento
    Dim dtConsultaRegistroInvestimentos As New DataTable
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Gerenciar Produtos"
        ConfigurarGrid()


    End Sub

    Private Sub Frm_GerenciarProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ConfigurarGrid()

        With Dgw_Ativos

            dtConsultaRegistroInvestimentos = ControladorInvestimento.ConsultaInvestimentos(ObjAtributos.AtbId)
            Dgw_Ativos.DataSource = dtConsultaRegistroInvestimentos
            '.Columns.Add("Id", "IdRegistro")
            '.Columns.Add("TipoAtivo", "Tipo Ativo")
            '.Columns.Add("SiglaAtivo", "Ativo")
            '.Columns.Add("Quantidade", "Qtd")
            '.Columns.Add("PrecoMedio", "Preço Medio")
            '.Columns.Add("PrecoCompra", "Preco compra")
            '.Columns.Add("TotalAplicado", "Total Aplicado")



        End With



    End Sub
End Class