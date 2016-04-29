namespace Email {
    interface BasicData {
        name: string,
        email: string,
        tel: string,
        join_type: Array<any>,
        content: string,
        response?: string
    }
    interface LoginResult {
        result: boolean;
        message: string;
        url: string;
    }
    $("#JoinUsInfo").submit(function (event) {
        event.preventDefault();

        let data: BasicData = {
            name: $("#m_name").val().replace(/<|>/g, ""),
            tel: $("#m_tel").val().replace(/<|>/g, ""),
            email: $("#m_email").val().replace(/<|>/g, ""),
            response: '',
            join_type: [],
            content: $("#m_content").val().replace(/<|>/g, "")
        };

        $("[name='join_type']:checked").map((i, item) =>
            data.join_type.push($(item).val())
        );
        if (data.join_type.length <= 0) {
            alert("請選擇「我想加入優靈客工作團隊 」或「我想成為講者」,\n 其中一項！");
            return;
        }
        $("body").mask("送信中請稍後...");
        $.ajax({
            type: "POST",
            url: gb_approot + 'Events/sendMail',
            data: data,
            dataType: 'json'
        }).done(function (result: LoginResult, textStatus, jqXHRdata) {
            $("body").unmask();
            alert(result.message);
        }).fail(function (jqXHR, textStatus, errorThrown) {
            $("body").unmask();
            alert(errorThrown);
        });


    });
}

