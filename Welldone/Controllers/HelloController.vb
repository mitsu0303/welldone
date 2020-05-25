Imports System.Web.Mvc

Namespace Controllers
    Public Class HelloController
        Inherits Controller

        ' GET: Hello
        Function Index() As ActionResult
            ViewBag.Message = "こんにちは、世界！"
            Return View()
        End Function
    End Class
End Namespace