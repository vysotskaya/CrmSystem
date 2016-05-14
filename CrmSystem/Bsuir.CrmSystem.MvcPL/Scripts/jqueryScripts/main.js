$(document).ready(function() {
    $("li[name='tabs']").click(function(event) {
        var idSelector = "#" + event.currentTarget.id;
        var lists = $("li[name='tabs']");
        for (var index = 0; index < lists.length; ++index) {
            var element = lists[index];
            if (element.hasAttribute('class', 'active')) {
                element.removeAttribute('class', 'active');
                $(idSelector).addClass('active');
                break;
            }
        }
    });
})