gx.evt.autoSkip=false;function gx01j0(){this.ServerClass="Gx01J0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV13pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV14pTipoParCodigo=gx.fn.getControlValue("vPTIPOPARCODIGO");this.AV15pMovMayorizadoId=gx.fn.getIntegerValue("vPMOVMAYORIZADOID",",");this.AV16pMovMayorizadoLinea=gx.fn.getIntegerValue("vPMOVMAYORIZADOLINEA",",")};this.e13212_client=function(){this.executeServerEvent("ENTER",true,arguments[0])
};this.e14211_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,12,14,17,19,22,24,27,29,32,34,37,39,42,44,47,48,52,53,54,55,56,57,58,59,60,61,64];this.GXLastCtrlId=64;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",51,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx01j0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",52,0,"px",17,"px",null,"","");
this.Grid1Container.addSingleLineEdit(41,53,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(199,54,"TIPOPARCODIGO","Tipo_Partida","","TipoParCodigo","svchar",0,"px",10,10,"left",null,[],199,"TipoParCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(217,55,"MOVMAYORIZADOID","Partida","","MovMayorizadoId","int",0,"px",9,9,"right",null,[],217,"MovMayorizadoId",true,0,false,false);
this.Grid1Container.addSingleLineEdit(218,56,"MOVMAYORIZADOLINEA","Línea","","MovMayorizadoLinea","int",0,"px",4,4,"right",null,[],218,"MovMayorizadoLinea",true,0,false,false);this.Grid1Container.addSingleLineEdit(219,57,"MOVMAYORIZADOFECHA","Fecha","Seleccionar","MovMayorizadoFecha","date",0,"px",8,8,"right",null,[],219,"MovMayorizadoFecha",true,0,false,false);this.Grid1Container.addSingleLineEdit(220,58,"MOVMAYORIZADOHORA","Hora","","MovMayorizadoHora","char",0,"px",8,8,"left",null,[],220,"MovMayorizadoHora",true,0,false,false);
this.Grid1Container.addSingleLineEdit(222,59,"MOVMAYORIZADOREFERENCIA","Referencia","","MovMayorizadoReferencia","svchar",0,"px",40,40,"left",null,[],222,"MovMayorizadoReferencia",true,0,false,false);this.Grid1Container.addSingleLineEdit(193,60,"CTACONTABLECODIGO","Cta_Contable","","CtaContableCodigo","svchar",0,"px",10,10,"left",null,[],193,"CtaContableCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(223,61,"MOVMAYORIZADODEBE","Debe","","MovMayorizadoDebe","decimal",0,"px",17,17,"right",null,[],223,"MovMayorizadoDebe",true,2,false,false);
this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCLINICACODIGO",gxz:"ZV6cClinicaCodigo",gxold:"OV6cClinicaCodigo",gxvar:"AV6cClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cClinicaCodigo=a
},v2z:function(a){gx.O.ZV6cClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("vCCLINICACODIGO",gx.O.AV6cClinicaCodigo,0)},c2v:function(){gx.O.AV6cClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKTIPOPARCODIGO",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCTIPOPARCODIGO",gxz:"ZV7cTipoParCodigo",gxold:"OV7cTipoParCodigo",gxvar:"AV7cTipoParCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cTipoParCodigo=a
},v2z:function(a){gx.O.ZV7cTipoParCodigo=a},v2c:function(){gx.fn.setControlValue("vCTIPOPARCODIGO",gx.O.AV7cTipoParCodigo,0)},c2v:function(){gx.O.AV7cTipoParCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCTIPOPARCODIGO")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKMOVMAYORIZADOID",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMOVMAYORIZADOID",gxz:"ZV8cMovMayorizadoId",gxold:"OV8cMovMayorizadoId",gxvar:"AV8cMovMayorizadoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cMovMayorizadoId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV8cMovMayorizadoId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCMOVMAYORIZADOID",gx.O.AV8cMovMayorizadoId,0)},c2v:function(){gx.O.AV8cMovMayorizadoId=this.val()},val:function(){return gx.fn.getIntegerValue("vCMOVMAYORIZADOID",",")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKMOVMAYORIZADOLINEA",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMOVMAYORIZADOLINEA",gxz:"ZV9cMovMayorizadoLinea",gxold:"OV9cMovMayorizadoLinea",gxvar:"AV9cMovMayorizadoLinea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cMovMayorizadoLinea=gx.num.intval(a)
},v2z:function(a){gx.O.ZV9cMovMayorizadoLinea=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCMOVMAYORIZADOLINEA",gx.O.AV9cMovMayorizadoLinea,0)},c2v:function(){gx.O.AV9cMovMayorizadoLinea=this.val()},val:function(){return gx.fn.getIntegerValue("vCMOVMAYORIZADOLINEA",",")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TEXTBLOCKMOVMAYORIZADOFECHA",format:0,grid:0};this.GXValidFnc[34]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCMOVMAYORIZADOFECHA",gxz:"ZV10cMovMayorizadoFecha",gxold:"OV10cMovMayorizadoFecha",gxvar:"AV10cMovMayorizadoFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10cMovMayorizadoFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV10cMovMayorizadoFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vCMOVMAYORIZADOFECHA",gx.O.AV10cMovMayorizadoFecha,0)},c2v:function(){gx.O.AV10cMovMayorizadoFecha=this.val()},val:function(){return gx.fn.getControlValue("vCMOVMAYORIZADOFECHA")},nac:function(){return false}};this.GXValidFnc[37]={fld:"TEXTBLOCKMOVMAYORIZADOHORA",format:0,grid:0};this.GXValidFnc[39]={lvl:0,type:"char",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCMOVMAYORIZADOHORA",gxz:"ZV11cMovMayorizadoHora",gxold:"OV11cMovMayorizadoHora",gxvar:"AV11cMovMayorizadoHora",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11cMovMayorizadoHora=a
},v2z:function(a){gx.O.ZV11cMovMayorizadoHora=a},v2c:function(){gx.fn.setControlValue("vCMOVMAYORIZADOHORA",gx.O.AV11cMovMayorizadoHora,0)},c2v:function(){gx.O.AV11cMovMayorizadoHora=this.val()},val:function(){return gx.fn.getControlValue("vCMOVMAYORIZADOHORA")},nac:function(){return false}};this.GXValidFnc[42]={fld:"TEXTBLOCKMOVMAYORIZADOREFERENCIA",format:0,grid:0};this.GXValidFnc[44]={lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCMOVMAYORIZADOREFERENCIA",gxz:"ZV12cMovMayorizadoReferencia",gxold:"OV12cMovMayorizadoReferencia",gxvar:"AV12cMovMayorizadoReferencia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV12cMovMayorizadoReferencia=a
},v2z:function(a){gx.O.ZV12cMovMayorizadoReferencia=a},v2c:function(){gx.fn.setControlValue("vCMOVMAYORIZADOREFERENCIA",gx.O.AV12cMovMayorizadoReferencia,0)},c2v:function(){gx.O.AV12cMovMayorizadoReferencia=this.val()},val:function(){return gx.fn.getControlValue("vCMOVMAYORIZADOREFERENCIA")},nac:function(){return false}};this.GXValidFnc[47]={fld:"GROUP2",grid:0};this.GXValidFnc[48]={fld:"TABLE3",grid:0};this.GXValidFnc[52]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[53]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[54]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"TIPOPARCODIGO",gxz:"Z199TipoParCodigo",gxold:"O199TipoParCodigo",gxvar:"A199TipoParCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A199TipoParCodigo=a
},v2z:function(a){gx.O.Z199TipoParCodigo=a},v2c:function(){gx.fn.setGridControlValue("TIPOPARCODIGO",gx.fn.currentGridRowImpl(51),gx.O.A199TipoParCodigo,0)},c2v:function(){gx.O.A199TipoParCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("TIPOPARCODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[55]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MOVMAYORIZADOID",gxz:"Z217MovMayorizadoId",gxold:"O217MovMayorizadoId",gxvar:"A217MovMayorizadoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A217MovMayorizadoId=gx.num.intval(a)
},v2z:function(a){gx.O.Z217MovMayorizadoId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("MOVMAYORIZADOID",gx.fn.currentGridRowImpl(51),gx.O.A217MovMayorizadoId,0)},c2v:function(){gx.O.A217MovMayorizadoId=this.val()},val:function(){return gx.fn.getGridIntegerValue("MOVMAYORIZADOID",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[56]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MOVMAYORIZADOLINEA",gxz:"Z218MovMayorizadoLinea",gxold:"O218MovMayorizadoLinea",gxvar:"A218MovMayorizadoLinea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A218MovMayorizadoLinea=gx.num.intval(a)
},v2z:function(a){gx.O.Z218MovMayorizadoLinea=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("MOVMAYORIZADOLINEA",gx.fn.currentGridRowImpl(51),gx.O.A218MovMayorizadoLinea,0)},c2v:function(){gx.O.A218MovMayorizadoLinea=this.val()},val:function(){return gx.fn.getGridIntegerValue("MOVMAYORIZADOLINEA",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[57]={lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"MOVMAYORIZADOFECHA",gxz:"Z219MovMayorizadoFecha",gxold:"O219MovMayorizadoFecha",gxvar:"A219MovMayorizadoFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A219MovMayorizadoFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z219MovMayorizadoFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("MOVMAYORIZADOFECHA",gx.fn.currentGridRowImpl(51),gx.O.A219MovMayorizadoFecha,0)},c2v:function(){gx.O.A219MovMayorizadoFecha=this.val()},val:function(){return gx.fn.getGridControlValue("MOVMAYORIZADOFECHA",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[58]={lvl:2,type:"char",len:8,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"MOVMAYORIZADOHORA",gxz:"Z220MovMayorizadoHora",gxold:"O220MovMayorizadoHora",gxvar:"A220MovMayorizadoHora",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A220MovMayorizadoHora=a
},v2z:function(a){gx.O.Z220MovMayorizadoHora=a},v2c:function(){gx.fn.setGridControlValue("MOVMAYORIZADOHORA",gx.fn.currentGridRowImpl(51),gx.O.A220MovMayorizadoHora,0)},c2v:function(){gx.O.A220MovMayorizadoHora=this.val()},val:function(){return gx.fn.getGridControlValue("MOVMAYORIZADOHORA",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[59]={lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"MOVMAYORIZADOREFERENCIA",gxz:"Z222MovMayorizadoReferencia",gxold:"O222MovMayorizadoReferencia",gxvar:"A222MovMayorizadoReferencia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A222MovMayorizadoReferencia=a
},v2z:function(a){gx.O.Z222MovMayorizadoReferencia=a},v2c:function(){gx.fn.setGridControlValue("MOVMAYORIZADOREFERENCIA",gx.fn.currentGridRowImpl(51),gx.O.A222MovMayorizadoReferencia,0)},c2v:function(){gx.O.A222MovMayorizadoReferencia=this.val()},val:function(){return gx.fn.getGridControlValue("MOVMAYORIZADOREFERENCIA",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[60]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CTACONTABLECODIGO",gxz:"Z193CtaContableCodigo",gxold:"O193CtaContableCodigo",gxvar:"A193CtaContableCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A193CtaContableCodigo=a
},v2z:function(a){gx.O.Z193CtaContableCodigo=a},v2c:function(){gx.fn.setGridControlValue("CTACONTABLECODIGO",gx.fn.currentGridRowImpl(51),gx.O.A193CtaContableCodigo,0)},c2v:function(){gx.O.A193CtaContableCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CTACONTABLECODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[61]={lvl:2,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MOVMAYORIZADODEBE",gxz:"Z223MovMayorizadoDebe",gxold:"O223MovMayorizadoDebe",gxvar:"A223MovMayorizadoDebe",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A223MovMayorizadoDebe=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z223MovMayorizadoDebe=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setGridDecimalValue("MOVMAYORIZADODEBE",gx.fn.currentGridRowImpl(51),gx.O.A223MovMayorizadoDebe,2,".")},c2v:function(){gx.O.A223MovMayorizadoDebe=this.val()},val:function(){return gx.fn.getGridDecimalValue("MOVMAYORIZADODEBE",gx.fn.currentGridRowImpl(51),",",".")},nac:function(){return false}};this.GXValidFnc[64]={fld:"TABLE4",grid:0};this.AV6cClinicaCodigo="";this.ZV6cClinicaCodigo="";this.OV6cClinicaCodigo="";
this.AV7cTipoParCodigo="";this.ZV7cTipoParCodigo="";this.OV7cTipoParCodigo="";this.AV8cMovMayorizadoId=0;this.ZV8cMovMayorizadoId=0;this.OV8cMovMayorizadoId=0;this.AV9cMovMayorizadoLinea=0;this.ZV9cMovMayorizadoLinea=0;this.OV9cMovMayorizadoLinea=0;this.AV10cMovMayorizadoFecha=gx.date.nullDate();this.ZV10cMovMayorizadoFecha=gx.date.nullDate();this.OV10cMovMayorizadoFecha=gx.date.nullDate();this.AV11cMovMayorizadoHora="";this.ZV11cMovMayorizadoHora="";this.OV11cMovMayorizadoHora="";this.AV12cMovMayorizadoReferencia="";
this.ZV12cMovMayorizadoReferencia="";this.OV12cMovMayorizadoReferencia="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z199TipoParCodigo="";this.O199TipoParCodigo="";this.Z217MovMayorizadoId=0;this.O217MovMayorizadoId=0;this.Z218MovMayorizadoLinea=0;this.O218MovMayorizadoLinea=0;this.Z219MovMayorizadoFecha=gx.date.nullDate();this.O219MovMayorizadoFecha=gx.date.nullDate();this.Z220MovMayorizadoHora="";this.O220MovMayorizadoHora="";this.Z222MovMayorizadoReferencia="";
this.O222MovMayorizadoReferencia="";this.Z193CtaContableCodigo="";this.O193CtaContableCodigo="";this.Z223MovMayorizadoDebe=0;this.O223MovMayorizadoDebe=0;this.AV13pClinicaCodigo="";this.AV14pTipoParCodigo="";this.AV15pMovMayorizadoId=0;this.AV16pMovMayorizadoLinea=0;this.AV5LinkSelection="";this.A41ClinicaCodigo="";this.A199TipoParCodigo="";this.A217MovMayorizadoId=0;this.A218MovMayorizadoLinea=0;this.A219MovMayorizadoFecha=gx.date.nullDate();this.A220MovMayorizadoHora="";this.A222MovMayorizadoReferencia="";
this.A193CtaContableCodigo="";this.A223MovMayorizadoDebe=0;this.ServerEvents=["e13212_client","e14211_client"];this.VarControlMap.AV13pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV14pTipoParCodigo={id:"vPTIPOPARCODIGO",grid:0,type:"svchar"};this.VarControlMap.AV15pMovMayorizadoId={id:"vPMOVMAYORIZADOID",grid:0,type:"int"};this.VarControlMap.AV16pMovMayorizadoLinea={id:"vPMOVMAYORIZADOLINEA",grid:0,type:"int"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);
this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[34]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[39]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[44]);this.SetStandaloneVars()}gx01j0.prototype=new gx.GxObject;gx.setParentObj(new gx01j0());