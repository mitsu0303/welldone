@ModelType Welldone.TRN_REVIEW
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.REVIEW_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
