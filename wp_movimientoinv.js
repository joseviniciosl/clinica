gx.evt.autoSkip=false;function wp_movimientoinv(){this.ServerClass="wp_movimientoinv";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e112x2_client=function(){this.executeServerEvent("'FIRST'",false)};this.e122x2_client=function(){this.executeServerEvent("'PREVIOUS'",false)};this.e132x2_client=function(){this.executeServerEvent("'NEXT'",false)};this.e142x2_client=function(){this.executeServerEvent("'LAST'",false)
};this.e152x2_client=function(){this.executeServerEvent("'REGRESAR'",false)};this.e162x2_client=function(){this.executeServerEvent("'NUEVO'",false)};this.e192x2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e202x2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,5,11,14,16,19,21,25,26,27,28,29,30,31];this.GXLastCtrlId=31;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",24,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"wp_movimientoinv",[],false,1,true,true,12,false,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
this.Grid1Container.addSingleLineEdit(41,25,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",false,0,false,false);this.Grid1Container.addSingleLineEdit(114,26,"TIPOMICODIGO","Tipo_Movimiento","","TipoMICodigo","svchar",0,"px",10,10,"left",null,[],114,"TipoMICodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(267,27,"MOVIMIENTOID","Id","","MovimientoId","int",0,"px",9,9,"right",null,[],267,"MovimientoId",true,0,false,false);this.Grid1Container.addSingleLineEdit(268,28,"MOVIMIENTOFECHA","Fecha","","MovimientoFecha","date",0,"px",8,8,"right",null,[],268,"MovimientoFecha",true,0,false,false);
this.Grid1Container.addSingleLineEdit(121,29,"BODEGACODIGO","Bodega","","BodegaCodigo","svchar",0,"px",10,10,"left",null,[],121,"BodegaCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(269,30,"MOVIMIENTOREFERENCIA","Referencia","","MovimientoReferencia","svchar",0,"px",40,40,"left",null,[],269,"MovimientoReferencia",true,0,false,false);this.Grid1Container.addComboBox(271,31,"MOVIMIENTOESTADO","Movimiento Estado","MovimientoEstado","int",null,0,true,false,0,"px");this.setGrid(this.Grid1Container);
this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[5]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[11]={fld:"TABLE2",grid:0};this.GXValidFnc[14]={fld:"TEXTBLOCK3",format:0,grid:0};this.GXValidFnc[16]={fld:"TEXTBLOCK4",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vMOVIMIENTOFECHAD",gxz:"ZV7MovimientoFechaD",gxold:"OV7MovimientoFechaD",gxvar:"AV7MovimientoFechaD",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7MovimientoFechaD=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV7MovimientoFechaD=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vMOVIMIENTOFECHAD",gx.O.AV7MovimientoFechaD,0)},c2v:function(){gx.O.AV7MovimientoFechaD=this.val()},val:function(){return gx.fn.getControlValue("vMOVIMIENTOFECHAD")},nac:function(){return false}};this.GXValidFnc[21]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vMOVIMIENTOFECHAA",gxz:"ZV8MovimientoFechaA",gxold:"OV8MovimientoFechaA",gxvar:"AV8MovimientoFechaA",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8MovimientoFechaA=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV8MovimientoFechaA=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vMOVIMIENTOFECHAA",gx.O.AV8MovimientoFechaA,0)},c2v:function(){gx.O.AV8MovimientoFechaA=this.val()},val:function(){return gx.fn.getControlValue("vMOVIMIENTOFECHAA")},nac:function(){return false}};this.GXValidFnc[25]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(24),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[26]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"TIPOMICODIGO",gxz:"Z114TipoMICodigo",gxold:"O114TipoMICodigo",gxvar:"A114TipoMICodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A114TipoMICodigo=a
},v2z:function(a){gx.O.Z114TipoMICodigo=a},v2c:function(){gx.fn.setGridControlValue("TIPOMICODIGO",gx.fn.currentGridRowImpl(24),gx.O.A114TipoMICodigo,0)},c2v:function(){gx.O.A114TipoMICodigo=this.val()},val:function(){return gx.fn.getGridControlValue("TIPOMICODIGO",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[27]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MOVIMIENTOID",gxz:"Z267MovimientoId",gxold:"O267MovimientoId",gxvar:"A267MovimientoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A267MovimientoId=gx.num.intval(a)
},v2z:function(a){gx.O.Z267MovimientoId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("MOVIMIENTOID",gx.fn.currentGridRowImpl(24),gx.O.A267MovimientoId,0)},c2v:function(){gx.O.A267MovimientoId=this.val()},val:function(){return gx.fn.getGridIntegerValue("MOVIMIENTOID",gx.fn.currentGridRowImpl(24),",")},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"MOVIMIENTOFECHA",gxz:"Z268MovimientoFecha",gxold:"O268MovimientoFecha",gxvar:"A268MovimientoFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A268MovimientoFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z268MovimientoFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("MOVIMIENTOFECHA",gx.fn.currentGridRowImpl(24),gx.O.A268MovimientoFecha,0)},c2v:function(){gx.O.A268MovimientoFecha=this.val()},val:function(){return gx.fn.getGridControlValue("MOVIMIENTOFECHA",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[29]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"BODEGACODIGO",gxz:"Z121BodegaCodigo",gxold:"O121BodegaCodigo",gxvar:"A121BodegaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A121BodegaCodigo=a
},v2z:function(a){gx.O.Z121BodegaCodigo=a},v2c:function(){gx.fn.setGridControlValue("BODEGACODIGO",gx.fn.currentGridRowImpl(24),gx.O.A121BodegaCodigo,0)},c2v:function(){gx.O.A121BodegaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("BODEGACODIGO",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[30]={lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"MOVIMIENTOREFERENCIA",gxz:"Z269MovimientoReferencia",gxold:"O269MovimientoReferencia",gxvar:"A269MovimientoReferencia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A269MovimientoReferencia=a
},v2z:function(a){gx.O.Z269MovimientoReferencia=a},v2c:function(){gx.fn.setGridControlValue("MOVIMIENTOREFERENCIA",gx.fn.currentGridRowImpl(24),gx.O.A269MovimientoReferencia,0)},c2v:function(){gx.O.A269MovimientoReferencia=this.val()},val:function(){return gx.fn.getGridControlValue("MOVIMIENTOREFERENCIA",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[31]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MOVIMIENTOESTADO",gxz:"Z271MovimientoEstado",gxold:"O271MovimientoEstado",gxvar:"A271MovimientoEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A271MovimientoEstado=gx.num.intval(a)
},v2z:function(a){gx.O.Z271MovimientoEstado=gx.num.intval(a)},v2c:function(){gx.fn.setGridComboBoxValue("MOVIMIENTOESTADO",gx.fn.currentGridRowImpl(24),gx.O.A271MovimientoEstado)},c2v:function(){gx.O.A271MovimientoEstado=this.val()},val:function(){return gx.fn.getGridIntegerValue("MOVIMIENTOESTADO",gx.fn.currentGridRowImpl(24),",")},nac:function(){return false}};this.AV7MovimientoFechaD=gx.date.nullDate();this.ZV7MovimientoFechaD=gx.date.nullDate();this.OV7MovimientoFechaD=gx.date.nullDate();this.AV8MovimientoFechaA=gx.date.nullDate();
this.ZV8MovimientoFechaA=gx.date.nullDate();this.OV8MovimientoFechaA=gx.date.nullDate();this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z114TipoMICodigo="";this.O114TipoMICodigo="";this.Z267MovimientoId=0;this.O267MovimientoId=0;this.Z268MovimientoFecha=gx.date.nullDate();this.O268MovimientoFecha=gx.date.nullDate();this.Z121BodegaCodigo="";this.O121BodegaCodigo="";this.Z269MovimientoReferencia="";this.O269MovimientoReferencia="";this.Z271MovimientoEstado=0;this.O271MovimientoEstado=0;this.A41ClinicaCodigo="";
this.A114TipoMICodigo="";this.A267MovimientoId=0;this.A268MovimientoFecha=gx.date.nullDate();this.A121BodegaCodigo="";this.A269MovimientoReferencia="";this.A271MovimientoEstado=0;this.ServerEvents=["e112x2_client","e122x2_client","e132x2_client","e142x2_client","e152x2_client","e162x2_client","e192x2_client","e202x2_client"];this.VarControlMap.AV5ClinicaCodigo={id:"vCLINICACODIGO",grid:0,type:"svchar"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[21]);
this.Grid1Container.addRefreshingVar({rfrVar:"AV5ClinicaCodigo"});this.SetStandaloneVars()}wp_movimientoinv.prototype=new gx.GxObject;gx.setParentObj(new wp_movimientoinv());