@ModelType Welldone.MST_SHOP
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
    <h4>MST_SHOP</h4>
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

    <!-- 店ID -->
    <div class="form-group">
        @Html.LabelFor(Function(model) model.SHOP_ID, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.SHOP_ID, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.SHOP_ID, "", New With {.class = "text-danger"})
        </div>
    </div>

    <!-- 店名 -->
    <div class="form-group">
        @Html.LabelFor(Function(model) model.SHOP_NAME, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.SHOP_NAME, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.SHOP_NAME, "", New With {.class = "text-danger"})
        </div>
    </div>

    <!-- カテゴリー -->
    <div class="form-group">
        @Html.LabelFor(Function(model) model.CATEGORY_ID, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @*  @Html.EditorFor(Function(model) model.CATEGORY_ID, New With {.htmlAttributes = New With {.class = "form-control"}}) *@
            @Html.DropDownList("CATEGORY_ID", DirectCast(ViewBag.CategoryOptions, IEnumerable(Of SelectListItem)), New With {.Class = "form-control"})
            @*@Html.DropDownList("CategoryIDs", "選択してください")*@
            @Html.ValidationMessageFor(Function(model) model.CATEGORY_ID, "", New With {.class = "text-danger"})
        </div>
    </div>

    <!-- 住所 -->
    <div class="form-group">
        @Html.LabelFor(Function(model) model.ADDRESS, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.ADDRESS, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.ADDRESS, "", New With {.class = "text-danger"})
        </div>
    </div>

    <!-- 開店時間 -->
    <div class="form-group">
        @Html.LabelFor(Function(model) model.OPEN_TIME, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.OPEN_TIME, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.OPEN_TIME, "", New With {.class = "text-danger"})
        </div>
    </div>

    <!-- 閉店時間 -->
    <div class="form-group">
        @Html.LabelFor(Function(model) model.CLOSE_TIME, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.CLOSE_TIME, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.CLOSE_TIME, "", New With {.class = "text-danger"})
        </div>
    </div>

    <!-- 説明 -->
    <div class="form-group">
        @Html.LabelFor(Function(model) model.DESCRIPTION, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DESCRIPTION, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.DESCRIPTION, "", New With {.class = "text-danger"})
        </div>
    </div>

    <!-- 削除フラグ -->
    <div class="form-group">
        @Html.LabelFor(Function(model) model.DEL_FLG, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DEL_FLG, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.DEL_FLG, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Create" class="btn btn-default" />
        </div>
    </div>
</div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>
