

var appoint_rec = null;
var appointments = new Array();

function ds_appoint() {
    var ds =
    {
        datatype: "json",
        datafields: [
            { name: 'user_id', type: 'string' },
            { name: 'id_key', type: 'string' },
            { name: 'start_date', type: 'date' },
            { name: 'end_date', type: 'date' },
            { name: 'subject', type: 'string' },
            { name: 'appoint_desc', type: 'string' },
            { name: 'appoint_alldays', type: 'number' },
            { name: 'appoint_status', type: 'char' },
           
        ],
        localdata: null
    };
    return ds;
}

function ds_calendar() {
    var ds =
    {
        dataType: "array",
        dataFields: [
            { name: 'id', type: 'string' },
            { name: 'description', type: 'string' },
            { name: 'location', type: 'string' },
            { name: 'subject', type: 'string' },
            { name: 'calendar', type: 'string' },
            { name: 'start', type: 'date' },
            { name: 'end', type: 'date' },
            { name: 'allday', type: 'boolean' },
            { name: 'readOnly', type: 'boolean' },
            { name: 'draggable', type: 'boolean' },
            { name: 'resizable', type: 'boolean' },
            { name: 'status', type: 'string' },
        ],
        id: 'id',
        localData: null// appointments
    };
    return ds;
}


function init_sch(ds) {
    $("#data_schedule").jqxScheduler({
        date: new $.jqx.date('todayDate'),
        height: 500,
        source: new $.jqx.dataAdapter(ds),
        view: 'weekView',
        showLegend: true,
        editDialog: false,
        contextMenu: false,
        dayNameFormat: "abbr",
        toolBarRangeFormat: 'dd MMM yy',
        
        localization: {
            // separator of parts of a date (e.g. '/' in 11/05/1955)
            '/': "/",
            // separator of parts of a time (e.g. ':' in 05:44 PM)
            ':': ":",
            // the first day of the week (0 = Sunday, 1 = Monday, etc)
            firstDay: 0,
            AM: ["AM", "null", "null"],
            PM: ["PM", "null", "null"],
            eras: [
                { "name": "A.D.", "start": null, "offset": 0 }
            ],

        },

        ready: function () {

        },

        resources:
        {
            //colorScheme: "scheme05",
            dataField: "calendar",
            source: new $.jqx.dataAdapter(ds)
        },
        appointmentDataFields:
        {
            from: "start",
            to: "end",
            id: "id",
            description: "description",
            location: "location",
            subject: "subject",
            resourceId: "calendar",
            allDay: "allday",
            readOnly: "readOnly",
            draggable: "draggable",
            resizable: "resizable",
            status: "status",
        },
        views:
            [
                { type: "agendaView", showWeekends: true, timeRuler: { formatString: "HH:mm", scaleStartHour: 7, scaleEndHour: 21 } },
                { type: "weekView", showWeekends: true, timeRuler: { formatString: "HH:mm", scaleStartHour: 7, scaleEndHour: 21 } },
                { type: 'monthView', monthRowAutoHeight: true }
            ]
    });

}

function push_data(d) {
    var ds = new ds_appoint();
    ds.localdata = d;
    var dsa = new $.jqx.dataAdapter(ds);
    dsa.dataBind();
    var records = dsa.records;

    for (var i = 0; i < records.length; i++) {
        var sd = records[i].start_date;
        var ed = records[i].end_date;
        var yy = sd.getFullYear();
        var mm = sd.getMonth();
        var dd = sd.getDate();
        var hh = sd.getHours();
        var cm = sd.getMinutes();
        var eyy = ed.getFullYear();
        var emm = ed.getMonth();
        var edd = ed.getDate();
        var ehh = ed.getHours();
        var ecm = ed.getMinutes();

        appointments.push({
            id: "id" + i,// records[i].id_key,
            subject: records[i].subject,
            location: records[i].appoint_status + "\n" + records[i].appoint_desc,
            description: records[i].appoint_desc,
            calendar: records[i].subject + "\n" + records[i].appoint_alldays,
            start: new Date(yy, mm, dd, hh, cm, 0),
            end: new Date(eyy, emm, edd, ehh, ecm, 0),
            allday: records[i].appoint_alldays,
            readOnly: true,
            draggable: false,
            resizable: false,
            status: records[i].appoint_status,
        });
    }

}

function load_data() {
    var svc = new mas;
    svc.getuser_appoint(connectString, "acc", onSuccess, onFail, null);
    function onSuccess(result) {
        $("#info_mode").text("");
        if (result[0] == "*") {
            message_info_dialog(result);
            return;
        }
      
        push_data(result);
        var ds = new ds_calendar();
        ds.localData = appointments;
        init_sch(ds);
    }

    function onFail(result) {
        $("#info_mode").text("");
        message_info_dialog(result);
    }

}
$('#data_schedule').on('appointmentClick', function (event) {
    var args = event.args;
    appoint_rec = args.appointment;
});
//'appointmentDoubleClick'
$('#data_schedule').on('appointmentClick', function (event) {
    var args = event.args;
    var d = args.appointment;
    if (d != null) {
        alert(d.subject + ",  " + d.id +",  " + d.location);
    }
});

load_data();

    
      
 

