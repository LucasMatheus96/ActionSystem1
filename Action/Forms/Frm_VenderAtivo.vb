Imports Action.Classes
Imports Action.Controller

Public Class Frm_VenderAtivo

    Dim controladorInvestimento As New ControladorInvestimento
    Public IdAtivo As Integer = 0
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Vender Ativos"
        Txt_Ativo.ReadOnly = True
        Txt_QuantidadeDisponivel.ReadOnly = True
        Txt_TotalVenda.ReadOnly = True
        Txt_PosicaoAtual.ReadOnly = True

    End Sub

    Private Sub Btn_Vender_Click(sender As Object, e As EventArgs) Handles Btn_Vender.Click

        'EFETUA O PROCEDIMENTO DE VENDA DOS ATIVOS E FAZ VALIDAÇÕES DE ACORDO COM A QUANTIDADE
        Try
            Dim objInvestimento As New Investimento
            objInvestimento.Id = IdAtivo
            objInvestimento.Quantidade = Val(Txt_QuantidadeDisponivel.Text) - Val(Txt_quantidadeVenda.Text)
            objInvestimento.PrecoTotal = Txt_PosicaoAtual.Text - Txt_TotalVenda.Text

            If Val(Txt_QuantidadeDisponivel.Text) = Val(Txt_quantidadeVenda.Text) Then

                controladorInvestimento.ExcluirInvestimento(IdAtivo)
                MessageBox.Show("Ativos vendido com sucesso", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            ElseIf Val(Txt_QuantidadeDisponivel.Text) > Val(Txt_quantidadeVenda.Text) Then

                controladorInvestimento.AlteraInvestimento(objInvestimento)
                MessageBox.Show("Ativos vendido com sucesso", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else

                MessageBox.Show("Quantidades de itens a serem vendidos é maior do você possui disponivel na sua carteira", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'FUNÇÃO PARA CALCULAR O TOTAL INVESTIDO
    Private Sub TotalInvestido()

        Try
            Dim precoAtivo As Double = Txt_PrecoVenda.Text
            Dim quantidade As Double = Txt_quantidadeVenda.Text
            Dim totalInvestido As Double = 0

            totalInvestido = precoAtivo * quantidade

            Txt_TotalVenda.Text = totalInvestido.ToString("C2")
        Catch ex As Exception
            Throw ex
        End Try

    End Sub



    Private Sub Txt_quantidadeVenda_TextChanged(sender As Object, e As EventArgs) Handles Txt_quantidadeVenda.TextChanged
        Try

            If String.IsNullOrEmpty(Txt_quantidadeVenda.Text) Then
                Txt_quantidadeVenda.Focus()
                Txt_TotalVenda.Text = ""
            ElseIf String.IsNullOrEmpty(Txt_PrecoVenda.Text) Then
                Txt_PrecoVenda.Focus()
                Txt_TotalVenda.Text = ""
            Else

                TotalInvestido()
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Txt_PrecoVenda_TextChanged(sender As Object, e As EventArgs) Handles Txt_PrecoVenda.TextChanged
        Try

            If String.IsNullOrEmpty(Txt_quantidadeVenda.Text) Then
                Txt_PrecoVenda.Focus()
                Txt_TotalVenda.Text = ""
            ElseIf String.IsNullOrEmpty(Txt_PrecoVenda.Text) Then
                Txt_quantidadeVenda.Focus()
                Txt_TotalVenda.Text = ""
            Else

                TotalInvestido()
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class