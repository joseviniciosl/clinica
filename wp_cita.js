gx.evt.autoSkip=false;function wp_cita(){this.ServerClass="wp_cita";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e112k2_client=function(){this.executeServerEvent("GXSCHEDULER1.EVENTADDED",true)};this.e122k2_client=function(){this.executeServerEvent("GXSCHEDULER1.EVENTDELETED",true)};this.e132k2_client=function(){this.executeServerEvent("GXSCHEDULER1.EVENTUPDATED",true)};this.e142k2_client=function(){this.executeServerEvent("GXSCHEDULER1.EVENTSELECTED",true)
};this.e152k2_client=function(){this.executeServerEvent("'REGRESAR'",false)};this.e182k2_client=function(){this.executeServerEvent("ENTER",true)};this.e192k2_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5];this.GXLastCtrlId=5;this.GXSCHEDULER1Container=gx.uc.getNew(this,14,0,"GXScheduler","GXSCHEDULER1Container","Gxscheduler1");this.GXSCHEDULER1Container.setProperty("AutoLoad","Autoload","month","str");this.GXSCHEDULER1Container.setProperty("LoadEventsObjectName","Loadeventsobjectname","LoadEventsSampleDP","str");
this.GXSCHEDULER1Container.setProperty("DetailsFormObjectName","Detailsformobjectname","","str");this.GXSCHEDULER1Container.setProperty("View","View","day","str");this.GXSCHEDULER1Container.setProperty("DefaultStepTime","Defaultsteptime",30,"num");this.GXSCHEDULER1Container.setProperty("DefaultLengthTime","Defaultlengthtime",60,"num");this.GXSCHEDULER1Container.setProperty("HourSize","Hoursize","2","str");this.GXSCHEDULER1Container.setProperty("FirstHour","Firsthour","8","str");this.GXSCHEDULER1Container.setProperty("LastHour","Lasthour","20","str");
this.GXSCHEDULER1Container.setProperty("ScrollHour","Scrollhour","0","str");this.GXSCHEDULER1Container.setProperty("Width","Width","1000","str");this.GXSCHEDULER1Container.setProperty("Height","Height","1000","str");this.GXSCHEDULER1Container.setProperty("AutoResize","Autoresize","true","str");this.GXSCHEDULER1Container.setProperty("PastEventsColor","Pasteventscolor",gx.color.fromRGB(255,231,99),"color");this.GXSCHEDULER1Container.setProperty("TodayEventsColor","Todayeventscolor",gx.color.fromRGB(255,231,99),"color");
this.GXSCHEDULER1Container.setProperty("FutureEventsColor","Futureeventscolor",gx.color.fromRGB(255,231,99),"color");this.GXSCHEDULER1Container.setProperty("DisplayMonthTab","Displaymonthtab","true","str");this.GXSCHEDULER1Container.setProperty("DisplayWeekTab","Displayweektab","true","str");this.GXSCHEDULER1Container.setProperty("DisplayDayTab","Displaydaytab","true","str");this.GXSCHEDULER1Container.setProperty("DisplayNavigationButtons","Displaynavigationbuttons","true","str");this.GXSCHEDULER1Container.setProperty("MonthEventsView","Montheventsview","singleline","str");
this.GXSCHEDULER1Container.setProperty("ReadOnly","Readonly","false","str");this.GXSCHEDULER1Container.setProperty("DetailsOnCreate","Detailsoncreate","true","str");this.GXSCHEDULER1Container.setProperty("DetailsOnDblClick","Detailsondblclick","true","str");this.GXSCHEDULER1Container.setProperty("OpenLinkNewWindow","Openlinknewwindow","false","str");this.GXSCHEDULER1Container.addV2CFunction(function(a){a.ParentObject.AV5currentEvent=gx.fn.getControlValue("vCURRENTEVENT");a.SetCurrentEvent(a.ParentObject.AV5currentEvent)
});this.GXSCHEDULER1Container.addC2VFunction(function(a){a.ParentObject.AV5currentEvent=a.GetCurrentEvent();gx.fn.setControlValue("vCURRENTEVENT",a.ParentObject.AV5currentEvent)});this.GXSCHEDULER1Container.addV2CFunction(function(a){a.ParentObject.AV6initialDate=gx.fn.getControlValue("vINITIALDATE");a.SetInitialDate(a.ParentObject.AV6initialDate)});this.GXSCHEDULER1Container.addC2VFunction(function(a){a.ParentObject.AV6initialDate=a.GetInitialDate();gx.fn.setControlValue("vINITIALDATE",a.ParentObject.AV6initialDate)
});this.GXSCHEDULER1Container.setProperty("Visible","Visible",true,"bool");this.GXSCHEDULER1Container.setC2ShowFunction(function(a){a.show()});this.GXSCHEDULER1Container.addEventHandler("EventAdded",this.e112k2_client);this.GXSCHEDULER1Container.addEventHandler("EventDeleted",this.e122k2_client);this.GXSCHEDULER1Container.addEventHandler("EventUpdated",this.e132k2_client);this.GXSCHEDULER1Container.addEventHandler("EventSelected",this.e142k2_client);this.setUserControl(this.GXSCHEDULER1Container);
this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[5]={fld:"TEXTBLOCK1",format:0,grid:0};this.AV5currentEvent={};this.ServerEvents=["e112k2_client","e122k2_client","e132k2_client","e142k2_client","e152k2_client","e182k2_client","e192k2_client"];this.SetStandaloneVars()}wp_cita.prototype=new gx.GxObject;gx.setParentObj(new wp_cita());