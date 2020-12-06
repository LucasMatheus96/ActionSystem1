Imports Action.classes
Imports Action.Controller

Public Class Frm_CadastraRendaFixa


    Dim NovaRendaFixa As New RendaFixa
    Dim controlRendaFixa As New ControladorRendaFixa
    Dim Dt As New DataTable

    Public idRendaFixa As Integer


    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Cadastrando Titulo"
        Dt = controlRendaFixa.ConsultarTipoRendaFixa
        Cmb_TipoTitulo.Items.Clear()
        Cmb_TipoTitulo.DropDownStyle = ComboBoxStyle.DropDownList

        For i As Integer = 0 To Dt.Rows.Count - 1
            Cmb_TipoTitulo.Items.Add(Dt.Rows(i)("SIGLA"))
        Next

    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()

    End Sub

    Private Sub Btn_Limpar_Click(sender As Object, e As EventArgs) Handles Btn_Limpar.Click
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        txt_titulo.Text = String.Empty
        TxT_RentabilidadeTitulo.Text = String.Empty
        Cmb_TipoTitulo.ResetText()
    End Sub

    Private Sub Btn_Cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_Cadastrar.Click

        If ValidaCampos() = False Then

            If idRendaFixa > 0 Then
                NovaRendaFixa.Id = idRendaFixa
                NovaRendaFixa.NomeAtivo = txt_titulo.Text
                NovaRendaFixa.IdTipoRendaFixa = Cmb_TipoTitulo.SelectedIndex + 1
                NovaRendaFixa.Rendimento = Val(TxT_RentabilidadeTitulo.Text)
                controlRendaFixa.AlterarRendaFixa(NovaRendaFixa)
                MsgBox("Titulo alterado com sucesso")
                Me.Close()

            Else
                NovaRendaFixa.NomeAtivo = txt_titulo.Text
                NovaRendaFixa.IdTipoRendaFixa = Cmb_TipoTitulo.SelectedIndex + 1
                NovaRendaFixa.Rendimento = Val(TxT_RentabilidadeTitulo.Text)
                controlRendaFixa.CadastrarRendaFixa(NovaRendaFixa)

                MsgBox("Titulo Cadastrado com sucesso")
                LimparCampo()
            End If




        End If

    End Sub

    Private Function ValidaCampos() As Boolean
        Dim vRetorno As Boolean

        If txt_titulo.Text = String.Empty Then

            MsgBox("O nome do titulo não foi preenchido")
            txt_titulo.Focus()
            vRetorno = True
        ElseIf Cmb_TipoTitulo.SelectedItem = Nothing Then

            MsgBox("Selecione o tipo Do titulo")
            Cmb_TipoTitulo.Focus()
            vRetorno = True

        ElseIf TxT_RentabilidadeTitulo.Text = String.Empty Then

            MsgBox("Informe a rentabilidade do titulo")
            TxT_RentabilidadeTitulo.Focus()
            vRetorno = True

        Else
            vRetorno = False
        End If


        Return vRetorno
    End Function

    Private Sub LimparCampo()

        txt_titulo.Text = String.Empty
        TxT_RentabilidadeTitulo.Text = String.Empty

    End Sub

    Private Sub Frm_CadastraRendaFixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Grb_RendaFixa_Enter(sender As Object, e As EventArgs) Handles Grb_RendaFixa.Enter

    End Sub
End Class