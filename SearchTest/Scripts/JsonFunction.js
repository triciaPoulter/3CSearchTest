"use strict";
    $(document).ready(function() {
        $("#btnSubmit").click(function() {
            var dataEntry = $("#profiles").val();
            $.ajax({
                url: "https://api.github.com/users/valor-software?callback?",
                data: "name="+ $("#profiles"),
                method: "Post",
                dataType: "json",
                success: function(data) {
                    if (dataEntry.val !== "valor-software") {
                        $("json"[name].name);
                    } else
                        $("#profiles").val(data.search(name));
                },
                error: function(err) {
                    alert(err);

                }
            });
        });
    });