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
    Public Class MST_SHOPController
        Inherits System.Web.Mvc.Controller

        Private db As New MyMvcContext

        ' GET: MST_SHOP
        Function Index() As ActionResult
            Return View(db.MST_SHOPs.ToList())
        End Function

        ' GET: MST_SHOP/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mST_SHOP As MST_SHOP = db.MST_SHOPs.Find(id)
            If IsNothing(mST_SHOP) Then
                Return HttpNotFound()
            End If
            Return View(mST_SHOP)
        End Function

        ' GET: MST_SHOP/Create
        Function Create() As ActionResult

            'ViewBag.CategoryIDs = New SelectList(db.MST_CATEGORYs, "CATEGORY_ID", "CATEGORY")

            ViewBag.CategoryOptions = db.MST_CATEGORYs.[Select](Function(s) New SelectListItem() With {
            .Text = s.CATEGORY,
            .Value = s.CATEGORY_ID})

            Return View()
        End Function

        ' POST: MST_SHOP/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="SHOP_ID,SHOP_NAME,CATEGORY_ID,ADDRESS,OPEN_TIME,CLOSE_TIME,DESCRIPTION,DEL_FLG")> ByVal mST_SHOP As MST_SHOP) As ActionResult
            If ModelState.IsValid Then
                db.MST_SHOPs.Add(mST_SHOP)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(mST_SHOP)
        End Function

        ' GET: MST_SHOP/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mST_SHOP As MST_SHOP = db.MST_SHOPs.Find(id)
            If IsNothing(mST_SHOP) Then
                Return HttpNotFound()
            End If
            Return View(mST_SHOP)
        End Function

        ' POST: MST_SHOP/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="SHOP_ID,SHOP_NAME,CATEGORY_ID,ADDRESS,OPEN_TIME,CLOSE_TIME,DESCRIPTION,DEL_FLG")> ByVal mST_SHOP As MST_SHOP) As ActionResult
            If ModelState.IsValid Then
                db.Entry(mST_SHOP).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(mST_SHOP)
        End Function

        ' GET: MST_SHOP/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mST_SHOP As MST_SHOP = db.MST_SHOPs.Find(id)
            If IsNothing(mST_SHOP) Then
                Return HttpNotFound()
            End If
            Return View(mST_SHOP)
        End Function

        ' POST: MST_SHOP/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim mST_SHOP As MST_SHOP = db.MST_SHOPs.Find(id)
            db.MST_SHOPs.Remove(mST_SHOP)
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
