Public Class Form1
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles Btn1.Click, btn3.Click, btn2.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        TextBox1.Text += CType(sender, Button).Text
    End Sub


End Class
