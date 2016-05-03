//<div class="alert alert-success" role="alert">...</div>
//<div class="alert alert-info" role="alert">...</div>
//<div class="alert alert-warning" role="alert">...</div>
//<div class="alert alert-danger" role="alert">...</div>
function alertTo(id, msg, type, obj) {
    var html = '<div class="alert alert-' + type + '" role="alert">' + msg + '</div>';
    $("#" + id).html(html); $("#" + id).fadeIn("slow"); obj;
    setTimeout(function () {
        $("#" + id).fadeOut("fast");
    }, 2000);
}
$(function ($) {
    //正则表达式
    var _regxExpression = {
        Email: /\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/,
        Phone: /^((\(\d{2,3}\))|(\d{3}\-))?13\d{9}$/,
    }

    //辅助校验方法
    var regxCheck = {
        IsControlValue: function (o_value, t_value) {
            if (o_value)
                return o_value;
            if (t_value)
                return t_value;
            //throw new Error("校验值有错误");
        },
        IsNull:function(value){
            if(value!==""
                &&value!==undefined
                &&value!==null
                &&typeof(value)!=="function"
                &&typeof(value)!=="Object")
            {
                return true;
            }
            else{
                return false;
            }
        }
        
    }

    //提示信息
    var _message = {
        IsNullMsg: "该字段不允许为空！",
        EmailMsg: "请输入正确的电子邮箱！",
        PhoneMsg: "请输入正确的电话号码！",
        AccountPhoneEmailMsg:"请输入正确的电子邮箱或电话号码！"
    }

    try {
        $.fn.extend({
            "Email": function (value) {
                var inputValue = regxCheck.IsControlValue($(this).val(), value);
                if (_regxExpression.Email.test(inputValue))
                    return true
                else
                    $(this).focus(); return false;
            },
            "Phone": function (value) {
                var inputValue = regxCheck.IsControlValue($(this).val(), value);
                if (_regxExpression.Phone.test(inputValue))
                    return true;
                else
                    $(this).focus(); return false;
            },
            "AccountPhoneEmail": function (value) {
                var inputValue = regxCheck.IsControlValue($(this).val(), value);
                return this.Email(inputValue) || this.Phone(inputValue);
                  
            },
            "IsNull": function (value) {
                var inputValue = regxCheck.IsControlValue($(this).val(), value);
                if (inputValue)
                    return true;
                else
                    $(this).focus(); return false;
            },
            "IsConfimPwd": function (o_id) {
                var oldPwd = $(this).val();
                var confirmPwd = $(o_id).val();
                if (!regxCheck.IsNull(oldPwd) && !regxCheck.IsNull(confirmPwd))
                    return false;
                if (oldPwd === confirmPwd)
                    return true;
                else
                    $(this).focus(); return false;
            },
            "IsChecked": function () {
               return $(this).is(":checked");
            },
            "MinduValidate": function () {
                var option = {
                    require: true,//验证是否为空
                    Email: false,
                    Phone: false,
                }
                //var inputValue = $(this).val();
                //this.Email()
            }
        });
    }
    catch (e) {
        console.log(e.message);
    }
});

