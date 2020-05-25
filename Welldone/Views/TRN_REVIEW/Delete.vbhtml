@ModelType Welldone.TRN_REVIEW
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>TRN_REVIEW</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.SHOP_ID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SHOP_ID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CONTRIBUTOR)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CONTRIBUTOR)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EVALUATION)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EVALUATION)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DEL_FLG)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DEL_FLG)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
