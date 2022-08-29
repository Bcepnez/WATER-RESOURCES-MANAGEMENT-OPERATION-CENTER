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
                depth: 45,
            }
        },
        series: [{
            colors: [
                'rgb(240, 75, 79)',
                'rgb(97, 121, 185)',
                'rgb(50, 191, 113)',
                'rgb(248, 199, 68)',
                'rgb(226, 153, 85)',
                'rgb(224, 224, 224)'
            ],
            name: data.name,
            dataLabels: data.dataLabels,
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
                depth: 45,
            }
        },
        series: [{
            colors: [
                'rgb(218, 53, 46)',
                'rgb(254, 138, 4)',
                'rgb(156, 238, 178)',
                'rgb(185, 218, 251)',
                'rgb(220, 220, 220)'
            ],
            name: data.name,
            dataLabels: data.dataLabels,
            data: data.data
        }]
    });
}