function initPageTable() {
    var tbody = ""
    $.ajax({
        type: 'POST',
        dataType: 'json',
        data: { page: "1" },
        url: '/Home/GetUserPageData',
        error: function () {
            alert('请求失败');
        },
        success: function (data) {
            $.each(data.list, function (i, n) {
                tbody += "<tr><td>" + (i+1) + "</td><td>" + n.Username + "</td><td>" + n.Birthday + "</td><td>" + (n.Sex == 1 ? '男' : '女') + "</td><td>" + n.Email + "</td><td>" + n.PhoneNumber + "</td></tr>";
            });

            $("#tableContent").html(tbody);
            var pageCount = data.pageCount;
            var currentPage = data.currentPage;

            var options = {
                bootstrapMajorVersion: 3,//版本
                currentPage: currentPage,
                totalPages: pageCount,
                numberOfPages: 5,
                itemTexts: function (type, page, current) {
                    switch (type) {
                        case "first":
                            return "首页";
                        case "prev":
                            return "上一页";
                        case "next":
                            return "下一页";
                        case "last":
                            return "末页";
                        case "page":
                            return page;
                    }
                },
                onPageClicked: function (event, originalEvent, type, page) {
                    $.ajax({
                        url: '/Home/GetUserPageData',
                        type: "Post",
                        dataType: "json",
                        data: "page=" + page,
                        success: function (data) {
                            var tbody1 = "";
                            $.each(data.list, function (i, n) {
                                tbody1 += "<tr><td>" + (i+1) + "</td><td>" + n.Username + "</td><td>" + n.Birthday + "</td><td>" + (n.Sex == 1 ? '男' : '女') + "</td><td>" + n.Email + "</td><td>" + n.PhoneNumber + "</td></tr>";
                            });
                            $("#tableContent").html(tbody1);
                        }
                    });
                }
            };
            $("#booPager").bootstrapPaginator(options);
        }
    });
}

function initMyPie() {
    var myChart = echarts.init(document.getElementById('userpie'))
    //显示标题，图例和空的坐标轴
    myChart.setOption({
        title: {
            text: '用户年龄段分析图',
            subtext: '',
            x: 'center',
            y: 50
        },
        tooltip: {
            trigger: 'item',
            formatter: "{a} <br/>{b} : {c} ({d}%)"
        },
        legend: {
            orient: '',
            left: 'left',
            top: 20,
            data: []
        },
        series: [{
            name: '年龄段',
            type: 'pie',
            radius: '55%',
            center: ['50%', '60%'],
            data: [
                { value: 335, name: '直接访问' },
            ],
            itemStyle: {
                emphasis: {
                    shadowBlur: 10,
                    shadowOffsetX: 10,
                    shadowColor: 'rgba(0,0,0,0.5)',
                    label: {
                        show: true,
                    }
                },
                normal: {
                    label: {
                        show: true,
                        formatter: function (value) {
                            if (value.percent> 2) {
                                return value.name + " :\n" + value.value + "(" + value.percent +")%";
                            }
                            else {
                                return "";
                            }
                        }
                    },
                    labelLine: {
                        show: false, length: 5
                    }
                }
            }
        }]
    });

    $.get('/Home/GetUserJson').done(function (data) {
        data = eval("" + data + "");
        //填入数据
        myChart.setOption({
            legend: {
                data: data
            },
            series: [{
                data: data
            }]
        });
    });

    myChart.on('click',function () {
        alert("click");
    });
}
