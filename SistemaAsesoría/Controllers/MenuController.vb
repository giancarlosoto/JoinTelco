Imports System.Web.Mvc

Namespace Controllers
    Public Class MenuController
        Inherits Controller

        Function Index() As ActionResult
            Return View()
        End Function
        Function viewPlanes() As ActionResult
            Return View()
        End Function
        Function registerPlanes() As ActionResult
            Return View()
        End Function
        Function consultarDeudas() As ActionResult
            Return View()
        End Function
        Function modificarPlan() As ActionResult
            Return View()
        End Function
        Function deletePlan() As ActionResult
            Return View()
        End Function
    End Class
End Namespace