$.ajax({
    url: '/api',
    type : 'GET',
    success: function(chartData){
        chartText = chartData.chartText;
        categories = chartData.categories;
        yText = chartData.yText;
        series = chartData.series;

        var myChart = Highcharts.chart('chart3', {
            chart: {
                type: 'bar',
                backgroundColor:'rgba(255, 255, 255, 0.0)'
            },
            title: {
                text: chartText
            },
            xAxis: {
                categories: categories
            },
            yAxis: {
                title: {
                    text: yText
                }
            },
            series: series
        });
    },
    error: function(jqXHR, textStatus, errorThrown) {

    }
});