Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Welldone

Namespace Controllers
    Public Class TRN_REVIEWController
        Inherits System.Web.Mvc.Controller

        Private db As New MyMvcContext

        ' GET: TRN_REVIEW
        Function Index() As ActionResult
            Return View(db.TRN_REVIEWs.ToList())
        End Function

        ' GET: TRN_REVIEW/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tRN_REVIEW As TRN_REVIEW = db.TRN_REVIEWs.Find(id)
            If IsNothing(tRN_REVIEW) Then
                Return HttpNotFound()
            End If
            Return View(tRN_REVIEW)
        End Function

        ' GET: TRN_REVIEW/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: TRN_REVIEW/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="REVIEW_ID,SHOP_ID,CONTRIBUTOR,EVALUATION,DEL_FLG")> ByVal tRN_REVIEW As TRN_REVIEW) As ActionResult
            If ModelState.IsValid Then
                db.TRN_REVIEWs.Add(tRN_REVIEW)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tRN_REVIEW)
        End Function

        ' GET: TRN_REVIEW/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tRN_REVIEW As TRN_REVIEW = db.TRN_REVIEWs.Find(id)
            If IsNothing(tRN_REVIEW) Then
                Return HttpNotFound()
            End If
            Return View(tRN_REVIEW)
        End Function

        ' POST: TRN_REVIEW/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="REVIEW_ID,SHOP_ID,CONTRIBUTOR,EVALUATION,DEL_FLG")> ByVal tRN_REVIEWs As TRN_REVIEW) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tRN_REVIEWs).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tRN_REVIEWs)
        End Function

        ' GET: TRN_REVIEW/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tRN_REVIEW As TRN_REVIEW = db.TRN_REVIEWs.Find(id)
            If IsNothing(tRN_REVIEW) Then
                Return HttpNotFound()
            End If
            Return View(tRN_REVIEW)
        End Function

        ' POST: TRN_REVIEW/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim tRN_REVIEW As TRN_REVIEW = db.TRN_REVIEWs.Find(id)
            db.TRN_REVIEWs.Remove(tRN_REVIEW)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
