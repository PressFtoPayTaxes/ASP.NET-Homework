function updateNews() {
    $.get({
        url: "UpdateNews",
        contentType: 'application/json',
        success(response) {
            console.log(response);
            htmlUpdate(response);
        },
        error(response) {
            console.log(response);
        }
    })
}

function htmlUpdate(posts) {
    $(".posts").html("");
    for (var i = 0; i < posts.length; i++) {
        $(".posts").append($(`<div class="col-md-12">
                                    <div class="post post-row">
                                        <a class="post-img" href="#"><img src="${posts[i].ImageLink}" alt=""></a>
                                        <div class="post-body">
                                            <h3 class="post-title"><a href="#">${posts[i].Header}</a></h3>
                                            <p>${posts[i].Text}</p>
                                        </div>
                                    </div>
                                </div>`));
    }
}

$(window).on("load", updateNews);
