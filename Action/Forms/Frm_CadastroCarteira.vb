
Imports Action.classes
Imports Action.Controller

Public Class Frm_CadastroCarteira
    Dim objDados As New Usuario
    Dim NovaCarteira As New Carteira
    Dim controlCarteira As New ControladorCarteira
    Dim controlUsuario As New ControladorUsuario
    Public IdCarteira As Integer = 0
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Cadastrar Carteira"
        Lbl_NomeCarteira.Text = "Nome da Carteira"
        Grp_CadastroCarteira.Text = "Cadastro"
        Btn_Cadastrar.Text = "Confirmar"
        Btn_Cancelar.Text = "Cancelar"
    End Sub

    Private Sub Frm_CadastroCarteira_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_Cadastrar.Click

        Try
            Dim dt As New DataTable
            dt = controlUsuario.ConsultarUsuario()
            Dim OperadorID As Integer

            'BUSCA INFORMAÇÃO DO USUARIO LOGADO
            Dim usuariologado As String = CapturaTexto(Frm_Principal.Tsl_UsuarioLogado.Text)

            'Captura o Id do operador referente ao usuario logado.
            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item(2) = usuariologado.ToString Then
                    OperadorID = dt.Rows(i)(0)
                End If
            Next

            If IdCarteira > 0 Then
                NovaCarteira.Id = IdCarteira
                NovaCarteira.NomeCarteira = Txt_NomeCarteira.Text
                controlCarteira.AtualizarCarteira(NovaCarteira)
                Me.Close()
            Else
                NovaCarteira.NomeCarteira = Txt_NomeCarteira.Text
                NovaCarteira.DataCadastro = Now
                NovaCarteira.operador = OperadorID
                controlCarteira.CadastrarCarteira(NovaCarteira)
            End If



        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try


    End Sub

    Private Function CapturaTexto(usuarioLogado As String) As String

        Dim indice1 As Integer = usuarioLogado.IndexOf(":")
        Dim NovoUsuarioLogado As String = usuarioLogado.Substring(indice1 + 2)

        Return NovoUsuarioLogado

    End Function

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub
End Class