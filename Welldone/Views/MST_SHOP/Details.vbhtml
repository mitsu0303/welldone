@ModelType Welldone.MST_SHOP
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>MST_SHOP</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.SHOP_NAME)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SHOP_NAME)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CATEGORY_ID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CATEGORY_ID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ADDRESS)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ADDRESS)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OPEN_TIME)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OPEN_TIME)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CLOSE_TIME)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CLOSE_TIME)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DESCRIPTION)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DESCRIPTION)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DEL_FLG)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DEL_FLG)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.SHOP_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
