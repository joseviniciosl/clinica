gx.evt.autoSkip=false;function gx01p0(){this.ServerClass="Gx01P0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV13pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV14pResolucionCodigo=gx.fn.getControlValue("vPRESOLUCIONCODIGO")};this.e132m2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e142m1_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];
this.GXCtrlIds=[2,8,9,12,14,17,19,22,24,27,29,32,34,37,39,42,44,47,48,52,53,54,55,56,57,58,59,60,63];this.GXLastCtrlId=63;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",51,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx01p0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",52,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(41,53,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",true,0,false,false);
this.Grid1Container.addSingleLineEdit(252,54,"RESOLUCIONCODIGO","Resolución","","ResolucionCodigo","svchar",0,"px",20,20,"left",null,[],252,"ResolucionCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(253,55,"RESOLUCIONFECHA","Fecha","Seleccionar","ResolucionFecha","date",0,"px",8,8,"right",null,[],253,"ResolucionFecha",true,0,false,false);this.Grid1Container.addSingleLineEdit(254,56,"RESOLUCIONVENCIMIENTO","Vencimiento","","ResolucionVencimiento","date",0,"px",8,8,"right",null,[],254,"ResolucionVencimiento",true,0,false,false);
this.Grid1Container.addSingleLineEdit(255,57,"RESOLUCIONSERIE","Serie","","ResolucionSerie","svchar",0,"px",20,20,"left",null,[],255,"ResolucionSerie",true,0,false,false);this.Grid1Container.addSingleLineEdit(256,58,"RESOLUCIONINICIAL","Inicial","","ResolucionInicial","int",0,"px",9,9,"right",null,[],256,"ResolucionInicial",true,0,false,false);this.Grid1Container.addSingleLineEdit(257,59,"RESOLUCIONFINAL","Final","","ResolucionFinal","int",0,"px",9,9,"right",null,[],257,"ResolucionFinal",true,0,false,false);
this.Grid1Container.addSingleLineEdit(258,60,"RESOLUCIONSIGUIENTE","Siguiente","","ResolucionSiguiente","int",0,"px",9,9,"right",null,[],258,"ResolucionSiguiente",true,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCLINICACODIGO",gxz:"ZV6cClinicaCodigo",gxold:"OV6cClinicaCodigo",gxvar:"AV6cClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cClinicaCodigo=a
},v2z:function(a){gx.O.ZV6cClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("vCCLINICACODIGO",gx.O.AV6cClinicaCodigo,0)},c2v:function(){gx.O.AV6cClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKRESOLUCIONCODIGO",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"svchar",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCRESOLUCIONCODIGO",gxz:"ZV7cResolucionCodigo",gxold:"OV7cResolucionCodigo",gxvar:"AV7cResolucionCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cResolucionCodigo=a
},v2z:function(a){gx.O.ZV7cResolucionCodigo=a},v2c:function(){gx.fn.setControlValue("vCRESOLUCIONCODIGO",gx.O.AV7cResolucionCodigo,0)},c2v:function(){gx.O.AV7cResolucionCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCRESOLUCIONCODIGO")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKRESOLUCIONFECHA",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCRESOLUCIONFECHA",gxz:"ZV8cResolucionFecha",gxold:"OV8cResolucionFecha",gxvar:"AV8cResolucionFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cResolucionFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV8cResolucionFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vCRESOLUCIONFECHA",gx.O.AV8cResolucionFecha,0)},c2v:function(){gx.O.AV8cResolucionFecha=this.val()},val:function(){return gx.fn.getControlValue("vCRESOLUCIONFECHA")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKRESOLUCIONVENCIMIENTO",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCRESOLUCIONVENCIMIENTO",gxz:"ZV9cResolucionVencimiento",gxold:"OV9cResolucionVencimiento",gxvar:"AV9cResolucionVencimiento",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cResolucionVencimiento=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV9cResolucionVencimiento=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vCRESOLUCIONVENCIMIENTO",gx.O.AV9cResolucionVencimiento,0)},c2v:function(){gx.O.AV9cResolucionVencimiento=this.val()},val:function(){return gx.fn.getControlValue("vCRESOLUCIONVENCIMIENTO")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TEXTBLOCKRESOLUCIONSERIE",format:0,grid:0};this.GXValidFnc[34]={lvl:0,type:"svchar",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCRESOLUCIONSERIE",gxz:"ZV10cResolucionSerie",gxold:"OV10cResolucionSerie",gxvar:"AV10cResolucionSerie",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10cResolucionSerie=a
},v2z:function(a){gx.O.ZV10cResolucionSerie=a},v2c:function(){gx.fn.setControlValue("vCRESOLUCIONSERIE",gx.O.AV10cResolucionSerie,0)},c2v:function(){gx.O.AV10cResolucionSerie=this.val()},val:function(){return gx.fn.getControlValue("vCRESOLUCIONSERIE")},nac:function(){return false}};this.GXValidFnc[37]={fld:"TEXTBLOCKRESOLUCIONINICIAL",format:0,grid:0};this.GXValidFnc[39]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCRESOLUCIONINICIAL",gxz:"ZV11cResolucionInicial",gxold:"OV11cResolucionInicial",gxvar:"AV11cResolucionInicial",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11cResolucionInicial=gx.num.intval(a)
},v2z:function(a){gx.O.ZV11cResolucionInicial=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCRESOLUCIONINICIAL",gx.O.AV11cResolucionInicial,0)},c2v:function(){gx.O.AV11cResolucionInicial=this.val()},val:function(){return gx.fn.getIntegerValue("vCRESOLUCIONINICIAL",",")},nac:function(){return false}};this.GXValidFnc[42]={fld:"TEXTBLOCKRESOLUCIONFINAL",format:0,grid:0};this.GXValidFnc[44]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCRESOLUCIONFINAL",gxz:"ZV12cResolucionFinal",gxold:"OV12cResolucionFinal",gxvar:"AV12cResolucionFinal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV12cResolucionFinal=gx.num.intval(a)
},v2z:function(a){gx.O.ZV12cResolucionFinal=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCRESOLUCIONFINAL",gx.O.AV12cResolucionFinal,0)},c2v:function(){gx.O.AV12cResolucionFinal=this.val()},val:function(){return gx.fn.getIntegerValue("vCRESOLUCIONFINAL",",")},nac:function(){return false}};this.GXValidFnc[47]={fld:"GROUP2",grid:0};this.GXValidFnc[48]={fld:"TABLE3",grid:0};this.GXValidFnc[52]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[53]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[54]={lvl:2,type:"svchar",len:20,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"RESOLUCIONCODIGO",gxz:"Z252ResolucionCodigo",gxold:"O252ResolucionCodigo",gxvar:"A252ResolucionCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A252ResolucionCodigo=a
},v2z:function(a){gx.O.Z252ResolucionCodigo=a},v2c:function(){gx.fn.setGridControlValue("RESOLUCIONCODIGO",gx.fn.currentGridRowImpl(51),gx.O.A252ResolucionCodigo,0)},c2v:function(){gx.O.A252ResolucionCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("RESOLUCIONCODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[55]={lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"RESOLUCIONFECHA",gxz:"Z253ResolucionFecha",gxold:"O253ResolucionFecha",gxvar:"A253ResolucionFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A253ResolucionFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z253ResolucionFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("RESOLUCIONFECHA",gx.fn.currentGridRowImpl(51),gx.O.A253ResolucionFecha,0)},c2v:function(){gx.O.A253ResolucionFecha=this.val()},val:function(){return gx.fn.getGridControlValue("RESOLUCIONFECHA",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[56]={lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"RESOLUCIONVENCIMIENTO",gxz:"Z254ResolucionVencimiento",gxold:"O254ResolucionVencimiento",gxvar:"A254ResolucionVencimiento",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A254ResolucionVencimiento=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z254ResolucionVencimiento=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("RESOLUCIONVENCIMIENTO",gx.fn.currentGridRowImpl(51),gx.O.A254ResolucionVencimiento,0)},c2v:function(){gx.O.A254ResolucionVencimiento=this.val()},val:function(){return gx.fn.getGridControlValue("RESOLUCIONVENCIMIENTO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[57]={lvl:2,type:"svchar",len:20,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"RESOLUCIONSERIE",gxz:"Z255ResolucionSerie",gxold:"O255ResolucionSerie",gxvar:"A255ResolucionSerie",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A255ResolucionSerie=a
},v2z:function(a){gx.O.Z255ResolucionSerie=a},v2c:function(){gx.fn.setGridControlValue("RESOLUCIONSERIE",gx.fn.currentGridRowImpl(51),gx.O.A255ResolucionSerie,0)},c2v:function(){gx.O.A255ResolucionSerie=this.val()},val:function(){return gx.fn.getGridControlValue("RESOLUCIONSERIE",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[58]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"RESOLUCIONINICIAL",gxz:"Z256ResolucionInicial",gxold:"O256ResolucionInicial",gxvar:"A256ResolucionInicial",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A256ResolucionInicial=gx.num.intval(a)
},v2z:function(a){gx.O.Z256ResolucionInicial=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("RESOLUCIONINICIAL",gx.fn.currentGridRowImpl(51),gx.O.A256ResolucionInicial,0)},c2v:function(){gx.O.A256ResolucionInicial=this.val()},val:function(){return gx.fn.getGridIntegerValue("RESOLUCIONINICIAL",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[59]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"RESOLUCIONFINAL",gxz:"Z257ResolucionFinal",gxold:"O257ResolucionFinal",gxvar:"A257ResolucionFinal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A257ResolucionFinal=gx.num.intval(a)
},v2z:function(a){gx.O.Z257ResolucionFinal=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("RESOLUCIONFINAL",gx.fn.currentGridRowImpl(51),gx.O.A257ResolucionFinal,0)},c2v:function(){gx.O.A257ResolucionFinal=this.val()},val:function(){return gx.fn.getGridIntegerValue("RESOLUCIONFINAL",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[60]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"RESOLUCIONSIGUIENTE",gxz:"Z258ResolucionSiguiente",gxold:"O258ResolucionSiguiente",gxvar:"A258ResolucionSiguiente",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A258ResolucionSiguiente=gx.num.intval(a)
},v2z:function(a){gx.O.Z258ResolucionSiguiente=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("RESOLUCIONSIGUIENTE",gx.fn.currentGridRowImpl(51),gx.O.A258ResolucionSiguiente,0)},c2v:function(){gx.O.A258ResolucionSiguiente=this.val()},val:function(){return gx.fn.getGridIntegerValue("RESOLUCIONSIGUIENTE",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[63]={fld:"TABLE4",grid:0};this.AV6cClinicaCodigo="";this.ZV6cClinicaCodigo="";this.OV6cClinicaCodigo="";
this.AV7cResolucionCodigo="";this.ZV7cResolucionCodigo="";this.OV7cResolucionCodigo="";this.AV8cResolucionFecha=gx.date.nullDate();this.ZV8cResolucionFecha=gx.date.nullDate();this.OV8cResolucionFecha=gx.date.nullDate();this.AV9cResolucionVencimiento=gx.date.nullDate();this.ZV9cResolucionVencimiento=gx.date.nullDate();this.OV9cResolucionVencimiento=gx.date.nullDate();this.AV10cResolucionSerie="";this.ZV10cResolucionSerie="";this.OV10cResolucionSerie="";this.AV11cResolucionInicial=0;this.ZV11cResolucionInicial=0;
this.OV11cResolucionInicial=0;this.AV12cResolucionFinal=0;this.ZV12cResolucionFinal=0;this.OV12cResolucionFinal=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z252ResolucionCodigo="";this.O252ResolucionCodigo="";this.Z253ResolucionFecha=gx.date.nullDate();this.O253ResolucionFecha=gx.date.nullDate();this.Z254ResolucionVencimiento=gx.date.nullDate();this.O254ResolucionVencimiento=gx.date.nullDate();this.Z255ResolucionSerie="";this.O255ResolucionSerie="";
this.Z256ResolucionInicial=0;this.O256ResolucionInicial=0;this.Z257ResolucionFinal=0;this.O257ResolucionFinal=0;this.Z258ResolucionSiguiente=0;this.O258ResolucionSiguiente=0;this.AV13pClinicaCodigo="";this.AV14pResolucionCodigo="";this.AV5LinkSelection="";this.A41ClinicaCodigo="";this.A252ResolucionCodigo="";this.A253ResolucionFecha=gx.date.nullDate();this.A254ResolucionVencimiento=gx.date.nullDate();this.A255ResolucionSerie="";this.A256ResolucionInicial=0;this.A257ResolucionFinal=0;this.A258ResolucionSiguiente=0;
this.ServerEvents=["e132m2_client","e142m1_client"];this.VarControlMap.AV13pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV14pResolucionCodigo={id:"vPRESOLUCIONCODIGO",grid:0,type:"svchar"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[34]);
this.Grid1Container.addRefreshingVar(this.GXValidFnc[39]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[44]);this.SetStandaloneVars()}gx01p0.prototype=new gx.GxObject;gx.setParentObj(new gx01p0());