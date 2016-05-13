Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fooRow1 As DS.fooRow = Me.Ds1.foo.AddfooRow("hoopla")
        Dim fooRow2 As DS.fooRow = Me.Ds1.foo.AddfooRow("blargh")

        Me.Ds1.bar.AddbarRow(fooRow1, "cheese")
        Me.Ds1.bar.AddbarRow(fooRow2, "chicken")
        Me.Ds1.bar.AddbarRow(fooRow1, "sprinkles")
        Me.Ds1.bar.AddbarRow(fooRow2, "soup")


    End Sub
End Class
