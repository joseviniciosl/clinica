gx.evt.autoSkip=false;function gx0190(){this.ServerClass="Gx0190";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV13pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV14pConsultaId=gx.fn.getIntegerValue("vPCONSULTAID",",");this.AV15pCargoId=gx.fn.getIntegerValue("vPCARGOID",",")};this.e131n2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e141n1_client=function(){this.executeServerEvent("CANCEL",true)
};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,12,14,17,19,22,24,27,29,32,34,37,39,42,44,47,48,52,53,54,55,56,57,58,59,62];this.GXLastCtrlId=62;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",51,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0190",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",52,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(41,53,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",true,0,false,false);
this.Grid1Container.addSingleLineEdit(91,54,"CONSULTAID","Consulta","","ConsultaId","int",0,"px",9,9,"right",null,[],91,"ConsultaId",true,0,false,false);this.Grid1Container.addSingleLineEdit(162,55,"CARGOID","Id","","CargoId","int",0,"px",9,9,"right",null,[],162,"CargoId",true,0,false,false);this.Grid1Container.addSingleLineEdit(30,56,"ARTICULOCODIGO","Artículo","","ArticuloCodigo","svchar",0,"px",10,10,"left",null,[],30,"ArticuloCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(163,57,"CARGOPRECIO","Precio","Seleccionar","CargoPrecio","decimal",0,"px",17,17,"right",null,[],163,"CargoPrecio",true,2,false,false);
this.Grid1Container.addSingleLineEdit(164,58,"CARGOCANTIDAD","Cantidad","","CargoCantidad","decimal",0,"px",17,17,"right",null,[],164,"CargoCantidad",true,2,false,false);this.Grid1Container.addComboBox(166,59,"CARGOESTADO","Estado","CargoEstado","int",null,0,true,false,0,"px");this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};
this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCLINICACODIGO",gxz:"ZV6cClinicaCodigo",gxold:"OV6cClinicaCodigo",gxvar:"AV6cClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cClinicaCodigo=a},v2z:function(a){gx.O.ZV6cClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("vCCLINICACODIGO",gx.O.AV6cClinicaCodigo,0)},c2v:function(){gx.O.AV6cClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCLINICACODIGO")
},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKCONSULTAID",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCONSULTAID",gxz:"ZV7cConsultaId",gxold:"OV7cConsultaId",gxvar:"AV7cConsultaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cConsultaId=gx.num.intval(a)},v2z:function(a){gx.O.ZV7cConsultaId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCCONSULTAID",gx.O.AV7cConsultaId,0)
},c2v:function(){gx.O.AV7cConsultaId=this.val()},val:function(){return gx.fn.getIntegerValue("vCCONSULTAID",",")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKCARGOID",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCARGOID",gxz:"ZV8cCargoId",gxold:"OV8cCargoId",gxvar:"AV8cCargoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cCargoId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV8cCargoId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCCARGOID",gx.O.AV8cCargoId,0)},c2v:function(){gx.O.AV8cCargoId=this.val()},val:function(){return gx.fn.getIntegerValue("vCCARGOID",",")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKARTICULOCODIGO",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCARTICULOCODIGO",gxz:"ZV9cArticuloCodigo",gxold:"OV9cArticuloCodigo",gxvar:"AV9cArticuloCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cArticuloCodigo=a
},v2z:function(a){gx.O.ZV9cArticuloCodigo=a},v2c:function(){gx.fn.setControlValue("vCARTICULOCODIGO",gx.O.AV9cArticuloCodigo,0)},c2v:function(){gx.O.AV9cArticuloCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCARTICULOCODIGO")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TEXTBLOCKCARGOPRECIO",format:0,grid:0};this.GXValidFnc[34]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCARGOPRECIO",gxz:"ZV10cCargoPrecio",gxold:"OV10cCargoPrecio",gxvar:"AV10cCargoPrecio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10cCargoPrecio=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.ZV10cCargoPrecio=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("vCCARGOPRECIO",gx.O.AV10cCargoPrecio,2,".")},c2v:function(){gx.O.AV10cCargoPrecio=this.val()},val:function(){return gx.fn.getDecimalValue("vCCARGOPRECIO",",",".")},nac:function(){return false}};this.GXValidFnc[37]={fld:"TEXTBLOCKCARGOCANTIDAD",format:0,grid:0};this.GXValidFnc[39]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCARGOCANTIDAD",gxz:"ZV11cCargoCantidad",gxold:"OV11cCargoCantidad",gxvar:"AV11cCargoCantidad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11cCargoCantidad=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.ZV11cCargoCantidad=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("vCCARGOCANTIDAD",gx.O.AV11cCargoCantidad,2,".")},c2v:function(){gx.O.AV11cCargoCantidad=this.val()},val:function(){return gx.fn.getDecimalValue("vCCARGOCANTIDAD",",",".")},nac:function(){return false}};this.GXValidFnc[42]={fld:"TEXTBLOCKCARGOESTADO",format:0,grid:0};this.GXValidFnc[44]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCARGOESTADO",gxz:"ZV12cCargoEstado",gxold:"OV12cCargoEstado",gxvar:"AV12cCargoEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV12cCargoEstado=gx.num.intval(a)
},v2z:function(a){gx.O.ZV12cCargoEstado=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("vCCARGOESTADO",gx.O.AV12cCargoEstado)},c2v:function(){gx.O.AV12cCargoEstado=this.val()},val:function(){return gx.fn.getIntegerValue("vCCARGOESTADO",",")},nac:function(){return false}};this.GXValidFnc[47]={fld:"GROUP2",grid:0};this.GXValidFnc[48]={fld:"TABLE3",grid:0};this.GXValidFnc[52]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[53]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[54]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CONSULTAID",gxz:"Z91ConsultaId",gxold:"O91ConsultaId",gxvar:"A91ConsultaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A91ConsultaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z91ConsultaId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("CONSULTAID",gx.fn.currentGridRowImpl(51),gx.O.A91ConsultaId,0)},c2v:function(){gx.O.A91ConsultaId=this.val()},val:function(){return gx.fn.getGridIntegerValue("CONSULTAID",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[55]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CARGOID",gxz:"Z162CargoId",gxold:"O162CargoId",gxvar:"A162CargoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A162CargoId=gx.num.intval(a)
},v2z:function(a){gx.O.Z162CargoId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("CARGOID",gx.fn.currentGridRowImpl(51),gx.O.A162CargoId,0)},c2v:function(){gx.O.A162CargoId=this.val()},val:function(){return gx.fn.getGridIntegerValue("CARGOID",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[56]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"ARTICULOCODIGO",gxz:"Z30ArticuloCodigo",gxold:"O30ArticuloCodigo",gxvar:"A30ArticuloCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A30ArticuloCodigo=a
},v2z:function(a){gx.O.Z30ArticuloCodigo=a},v2c:function(){gx.fn.setGridControlValue("ARTICULOCODIGO",gx.fn.currentGridRowImpl(51),gx.O.A30ArticuloCodigo,0)},c2v:function(){gx.O.A30ArticuloCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("ARTICULOCODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[57]={lvl:2,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CARGOPRECIO",gxz:"Z163CargoPrecio",gxold:"O163CargoPrecio",gxvar:"A163CargoPrecio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A163CargoPrecio=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z163CargoPrecio=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setGridDecimalValue("CARGOPRECIO",gx.fn.currentGridRowImpl(51),gx.O.A163CargoPrecio,2,".")},c2v:function(){gx.O.A163CargoPrecio=this.val()},val:function(){return gx.fn.getGridDecimalValue("CARGOPRECIO",gx.fn.currentGridRowImpl(51),",",".")},nac:function(){return false}};this.GXValidFnc[58]={lvl:2,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CARGOCANTIDAD",gxz:"Z164CargoCantidad",gxold:"O164CargoCantidad",gxvar:"A164CargoCantidad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A164CargoCantidad=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z164CargoCantidad=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setGridDecimalValue("CARGOCANTIDAD",gx.fn.currentGridRowImpl(51),gx.O.A164CargoCantidad,2,".")},c2v:function(){gx.O.A164CargoCantidad=this.val()},val:function(){return gx.fn.getGridDecimalValue("CARGOCANTIDAD",gx.fn.currentGridRowImpl(51),",",".")},nac:function(){return false}};this.GXValidFnc[59]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CARGOESTADO",gxz:"Z166CargoEstado",gxold:"O166CargoEstado",gxvar:"A166CargoEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A166CargoEstado=gx.num.intval(a)
},v2z:function(a){gx.O.Z166CargoEstado=gx.num.intval(a)},v2c:function(){gx.fn.setGridComboBoxValue("CARGOESTADO",gx.fn.currentGridRowImpl(51),gx.O.A166CargoEstado)},c2v:function(){gx.O.A166CargoEstado=this.val()},val:function(){return gx.fn.getGridIntegerValue("CARGOESTADO",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[62]={fld:"TABLE4",grid:0};this.AV6cClinicaCodigo="";this.ZV6cClinicaCodigo="";this.OV6cClinicaCodigo="";this.AV7cConsultaId=0;this.ZV7cConsultaId=0;
this.OV7cConsultaId=0;this.AV8cCargoId=0;this.ZV8cCargoId=0;this.OV8cCargoId=0;this.AV9cArticuloCodigo="";this.ZV9cArticuloCodigo="";this.OV9cArticuloCodigo="";this.AV10cCargoPrecio=0;this.ZV10cCargoPrecio=0;this.OV10cCargoPrecio=0;this.AV11cCargoCantidad=0;this.ZV11cCargoCantidad=0;this.OV11cCargoCantidad=0;this.AV12cCargoEstado=0;this.ZV12cCargoEstado=0;this.OV12cCargoEstado=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z91ConsultaId=0;
this.O91ConsultaId=0;this.Z162CargoId=0;this.O162CargoId=0;this.Z30ArticuloCodigo="";this.O30ArticuloCodigo="";this.Z163CargoPrecio=0;this.O163CargoPrecio=0;this.Z164CargoCantidad=0;this.O164CargoCantidad=0;this.Z166CargoEstado=0;this.O166CargoEstado=0;this.AV13pClinicaCodigo="";this.AV14pConsultaId=0;this.AV15pCargoId=0;this.AV5LinkSelection="";this.A41ClinicaCodigo="";this.A91ConsultaId=0;this.A162CargoId=0;this.A30ArticuloCodigo="";this.A163CargoPrecio=0;this.A164CargoCantidad=0;this.A166CargoEstado=0;
this.ServerEvents=["e131n2_client","e141n1_client"];this.VarControlMap.AV13pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV14pConsultaId={id:"vPCONSULTAID",grid:0,type:"int"};this.VarControlMap.AV15pCargoId={id:"vPCARGOID",grid:0,type:"int"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);
this.Grid1Container.addRefreshingVar(this.GXValidFnc[34]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[39]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[44]);this.SetStandaloneVars()}gx0190.prototype=new gx.GxObject;gx.setParentObj(new gx0190());