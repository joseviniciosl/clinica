gx.evt.autoSkip=false;function schedulerdetailsform(){this.ServerClass="SchedulerDetailsForm";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.e13232_client=function(){this.executeServerEvent("ENTER",true)};this.e14232_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[5,8,10,13,15,18,20];this.GXLastCtrlId=20;this.GXValidFnc[5]={fld:"TABLE1",grid:0};
this.GXValidFnc[8]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[10]={lvl:0,type:"char",len:20,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vEVENTID",gxz:"ZV8eventId",gxold:"OV8eventId",gxvar:"AV8eventId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8eventId=a},v2z:function(a){gx.O.ZV8eventId=a},v2c:function(){gx.fn.setControlValue("vEVENTID",gx.O.AV8eventId,0)},c2v:function(){gx.O.AV8eventId=this.val()},val:function(){return gx.fn.getControlValue("vEVENTID")
},nac:function(){return false}};this.GXValidFnc[13]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[15]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vEVENTSTARTTIME",gxz:"ZV9eventStartTime",gxold:"OV9eventStartTime",gxvar:"AV9eventStartTime",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9eventStartTime=gx.fn.toDatetimeValue(a)},v2z:function(a){gx.O.ZV9eventStartTime=gx.fn.toDatetimeValue(a)
},v2c:function(){gx.fn.setControlValue("vEVENTSTARTTIME",gx.O.AV9eventStartTime,0)},c2v:function(){gx.O.AV9eventStartTime=this.val()},val:function(){return gx.fn.getControlValue("vEVENTSTARTTIME")},nac:function(){return false}};this.GXValidFnc[18]={fld:"TEXTBLOCK3",format:0,grid:0};this.GXValidFnc[20]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vEVENTENDTIME",gxz:"ZV7eventEndTime",gxold:"OV7eventEndTime",gxvar:"AV7eventEndTime",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7eventEndTime=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV7eventEndTime=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vEVENTENDTIME",gx.O.AV7eventEndTime,0)},c2v:function(){gx.O.AV7eventEndTime=this.val()},val:function(){return gx.fn.getControlValue("vEVENTENDTIME")},nac:function(){return false}};this.AV8eventId="";this.ZV8eventId="";this.OV8eventId="";this.AV9eventStartTime=gx.date.nullDate();this.ZV9eventStartTime=gx.date.nullDate();this.OV9eventStartTime=gx.date.nullDate();this.AV7eventEndTime=gx.date.nullDate();
this.ZV7eventEndTime=gx.date.nullDate();this.OV7eventEndTime=gx.date.nullDate();this.Gx_mode="";this.ServerEvents=["e13232_client","e14232_client"];this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}schedulerdetailsform.prototype=new gx.GxObject;gx.setParentObj(new schedulerdetailsform());