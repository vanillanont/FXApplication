


$(document).ready(function (e) { 
    var data = new Object(); 
    $.ajax({
        contentType: 'application/json',
        type: "POST",
        url: "/api/EASetting/getUserPatterns",
        data: JSON.stringify({
            user_id: "kkk",
            token: "yyyy"
        }),
        success: function (s, textStatus, jqXHR) {
            data = JSON.parse(jqXHR.responseText);
            data = (data._EAStrategyPattern[0]._EAChartGroup[0]._EAChart[0]._EAOHLC); 

            alert(data[0]["date"]);
            //$.getJSON('https://www.highcharts.com/samples/data/aapl-ohlcv.json', function (data) {

                // split the data set into ohlc and volume
                var ohlc = [],
                    volume = [],
                    dataLength = data.length,
                    // set the allowed units for data grouping
                    groupingUnits = [[
                        'week',                         // unit name
                        [1]                             // allowed multiples
                    ], [
                        'month',
                        [1, 2, 3, 4, 6]
                    ]],

                    i = 0;

                for (i; i < dataLength; i += 1) {
                    ohlc.push([
                        data[i]["date"], // the date
                        data[i]["open"], // open
                        data[i]["high"], // high
                        data[i]["low"], // low
                        data[i]["close"] // close
                    ]);

                    volume.push([
                        data[i]["date"], // the date
                        data[i]["volume"] // the volume
                    ]);
                }


                // create the chart
                Highcharts.stockChart('chart01', {

                    rangeSelector: {
                        selected: 1
                    },

                    title: {
                        text: 'AAPL Historical'
                    },

                    yAxis: [{
                        labels: {
                            align: 'right',
                            x: -3
                        },
                        title: {
                            text: 'OHLC'
                        },
                        height: '60%',
                        lineWidth: 2,
                        resize: {
                            enabled: true
                        }
                    }, {
                        labels: {
                            align: 'right',
                            x: -3
                        },
                        title: {
                            text: 'Volume'
                        },
                        top: '65%',
                        height: '35%',
                        offset: 0,
                        lineWidth: 2
                    }],

                    tooltip: {
                        split: true
                    },

                    series: [{
                        type: 'candlestick',
                        name: 'AAPL',
                        data: ohlc,
                        dataGrouping: {
                            units: groupingUnits
                        }
                    }, {
                        type: 'column',
                        name: 'Volume',
                        data: volume,
                        yAxis: 1,
                        dataGrouping: {
                            units: groupingUnits
                        }
                    }]
                }); 

        },
        error: function (jqXHR, textStatus, errorThrown) { 
        }
    });
});  


