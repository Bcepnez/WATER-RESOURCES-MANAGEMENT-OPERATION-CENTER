function CreateWaterStation_Highchart(data) {
    Highcharts.chart('water_station_chart', {
        chart: {
            type: 'pie',
            options3d: {
                enabled: false,
                alpha: 45
            }
        },
        title: {
            text: data.name
        },
        // subtitle: {
        //     text: '3D donut in Highcharts'
        // },
        plotOptions: {
            pie: {
                innerSize: 100,
                depth: 45
            }
        },
        series: [{
            name: data.name,
            data: data.data
        }]
    });
}

function CreateRainLevel_Highchart(data) {
    Highcharts.chart('rain_level_chart', {
        chart: {
            type: 'pie',
            options3d: {
                enabled: false,
                alpha: 45
            }
        },
        title: {
            text: data.name
        },
        // subtitle: {
        //     text: '3D donut in Highcharts'
        // },
        plotOptions: {
            pie: {
                innerSize: 100,
                depth: 45
            }
        },
        series: [{
            name: data.name,
            data: data.data
        }]
    });
}