gx.evt.autoSkip=false;function movimientomayorizado(){this.ServerClass="MovimientoMayorizado";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Clinicacodigo=function(){try{var a=gx.util.balloon.getNew("CLINICACODIGO");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Tipoparcodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Tipoparcodigo",["gx.O.A41ClinicaCodigo","gx.O.A199TipoParCodigo"],[]);
return true};this.Valid_Movmayorizadoid=function(){try{var a=gx.util.balloon.getNew("MOVMAYORIZADOID");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Movmayorizadolinea=function(){gx.ajax.validSrvEvt("dyncall","Valid_Movmayorizadolinea",["gx.O.A41ClinicaCodigo","gx.O.A199TipoParCodigo","gx.O.A217MovMayorizadoId","gx.O.A218MovMayorizadoLinea",'gx.date.urlDate(gx.O.A219MovMayorizadoFecha,"DMY")',"gx.O.A220MovMayorizadoHora","gx.O.A221MovMayorizadoObs","gx.O.A222MovMayorizadoReferencia","gx.num.urlDecimal(gx.O.A223MovMayorizadoDebe,',','.')","gx.num.urlDecimal(gx.O.A224MovMayorizadoHaber,',','.')","gx.O.A193CtaContableCodigo","gx.O.A4UsuarioCodigo"],["A219MovMayorizadoFecha","A220MovMayorizadoHora","A221MovMayorizadoObs","A222MovMayorizadoReferencia","A193CtaContableCodigo","A223MovMayorizadoDebe","A224MovMayorizadoHaber","A4UsuarioCodigo","Gx_mode","Z41ClinicaCodigo","Z199TipoParCodigo","Z217MovMayorizadoId","Z218MovMayorizadoLinea","Z219MovMayorizadoFecha","Z220MovMayorizadoHora","Z221MovMayorizadoObs","Z222MovMayorizadoReferencia","Z193CtaContableCodigo","Z223MovMayorizadoDebe","Z224MovMayorizadoHaber","Z4UsuarioCodigo",["BTN_DELETE2","Enabled"],["BTN_ENTER2","Enabled"]]);
return true};this.Valid_Movmayorizadofecha=function(){try{var a=gx.util.balloon.getNew("MOVMAYORIZADOFECHA");this.AnyError=0;if(!((new gx.date.gxdate("").compare(this.A219MovMayorizadoFecha)==0)||new gx.date.gxdate(this.A219MovMayorizadoFecha).compare(gx.date.ymdtod(1753,1,1))>=0)){try{a.setError("Campo Fecha fuera de rango");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Ctacontablecodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Ctacontablecodigo",["gx.O.A41ClinicaCodigo","gx.O.A193CtaContableCodigo"],[]);
return true};this.Valid_Usuariocodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Usuariocodigo",["gx.O.A4UsuarioCodigo"],[]);return true};this.e111655_client=function(){this.executeServerEvent("ENTER",true)};this.e121655_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,51,53,56,58,61,63,66,68,71,73,76,78,81,83,86,88,91,93,99,100,101];this.GXLastCtrlId=101;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};
this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};
this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};
this.GXValidFnc[38]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("CLINICACODIGO",gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CLINICACODIGO")
},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKTIPOPARCODIGO",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Tipoparcodigo,isvalid:null,fld:"TIPOPARCODIGO",gxz:"Z199TipoParCodigo",gxold:"O199TipoParCodigo",gxvar:"A199TipoParCodigo",ucs:[],op:[],ip:[43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A199TipoParCodigo=a},v2z:function(a){gx.O.Z199TipoParCodigo=a},v2c:function(){gx.fn.setControlValue("TIPOPARCODIGO",gx.O.A199TipoParCodigo,0)
},c2v:function(){gx.O.A199TipoParCodigo=this.val()},val:function(){return gx.fn.getControlValue("TIPOPARCODIGO")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKMOVMAYORIZADOID",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Movmayorizadoid,isvalid:null,rgrid:[],fld:"MOVMAYORIZADOID",gxz:"Z217MovMayorizadoId",gxold:"O217MovMayorizadoId",gxvar:"A217MovMayorizadoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A217MovMayorizadoId=gx.num.intval(a)
},v2z:function(a){gx.O.Z217MovMayorizadoId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("MOVMAYORIZADOID",gx.O.A217MovMayorizadoId,0)},c2v:function(){gx.O.A217MovMayorizadoId=this.val()},val:function(){return gx.fn.getIntegerValue("MOVMAYORIZADOID",",")},nac:function(){return false}};this.GXValidFnc[51]={fld:"TEXTBLOCKMOVMAYORIZADOLINEA",format:0,grid:0};this.GXValidFnc[53]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Movmayorizadolinea,isvalid:null,rgrid:[],fld:"MOVMAYORIZADOLINEA",gxz:"Z218MovMayorizadoLinea",gxold:"O218MovMayorizadoLinea",gxvar:"A218MovMayorizadoLinea",ucs:[],op:[93,78,88,83,73,68,63,58],ip:[93,78,88,83,73,68,63,58,53,48,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A218MovMayorizadoLinea=gx.num.intval(a)
},v2z:function(a){gx.O.Z218MovMayorizadoLinea=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("MOVMAYORIZADOLINEA",gx.O.A218MovMayorizadoLinea,0)},c2v:function(){gx.O.A218MovMayorizadoLinea=this.val()},val:function(){return gx.fn.getIntegerValue("MOVMAYORIZADOLINEA",",")},nac:function(){return false}};this.GXValidFnc[56]={fld:"TEXTBLOCKMOVMAYORIZADOFECHA",format:0,grid:0};this.GXValidFnc[58]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Movmayorizadofecha,isvalid:null,fld:"MOVMAYORIZADOFECHA",gxz:"Z219MovMayorizadoFecha",gxold:"O219MovMayorizadoFecha",gxvar:"A219MovMayorizadoFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[58],ip:[58],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A219MovMayorizadoFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z219MovMayorizadoFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("MOVMAYORIZADOFECHA",gx.O.A219MovMayorizadoFecha,0)},c2v:function(){gx.O.A219MovMayorizadoFecha=this.val()},val:function(){return gx.fn.getControlValue("MOVMAYORIZADOFECHA")},nac:function(){return false}};this.GXValidFnc[61]={fld:"TEXTBLOCKMOVMAYORIZADOHORA",format:0,grid:0};this.GXValidFnc[63]={lvl:0,type:"char",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"MOVMAYORIZADOHORA",gxz:"Z220MovMayorizadoHora",gxold:"O220MovMayorizadoHora",gxvar:"A220MovMayorizadoHora",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A220MovMayorizadoHora=a
},v2z:function(a){gx.O.Z220MovMayorizadoHora=a},v2c:function(){gx.fn.setControlValue("MOVMAYORIZADOHORA",gx.O.A220MovMayorizadoHora,0)},c2v:function(){gx.O.A220MovMayorizadoHora=this.val()},val:function(){return gx.fn.getControlValue("MOVMAYORIZADOHORA")},nac:function(){return false}};this.GXValidFnc[66]={fld:"TEXTBLOCKMOVMAYORIZADOOBS",format:0,grid:0};this.GXValidFnc[68]={lvl:0,type:"svchar",len:600,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"MOVMAYORIZADOOBS",gxz:"Z221MovMayorizadoObs",gxold:"O221MovMayorizadoObs",gxvar:"A221MovMayorizadoObs",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A221MovMayorizadoObs=a
},v2z:function(a){gx.O.Z221MovMayorizadoObs=a},v2c:function(){gx.fn.setControlValue("MOVMAYORIZADOOBS",gx.O.A221MovMayorizadoObs,0)},c2v:function(){gx.O.A221MovMayorizadoObs=this.val()},val:function(){return gx.fn.getControlValue("MOVMAYORIZADOOBS")},nac:function(){return false}};this.GXValidFnc[71]={fld:"TEXTBLOCKMOVMAYORIZADOREFERENCIA",format:0,grid:0};this.GXValidFnc[73]={lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"MOVMAYORIZADOREFERENCIA",gxz:"Z222MovMayorizadoReferencia",gxold:"O222MovMayorizadoReferencia",gxvar:"A222MovMayorizadoReferencia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A222MovMayorizadoReferencia=a
},v2z:function(a){gx.O.Z222MovMayorizadoReferencia=a},v2c:function(){gx.fn.setControlValue("MOVMAYORIZADOREFERENCIA",gx.O.A222MovMayorizadoReferencia,0)},c2v:function(){gx.O.A222MovMayorizadoReferencia=this.val()},val:function(){return gx.fn.getControlValue("MOVMAYORIZADOREFERENCIA")},nac:function(){return false}};this.GXValidFnc[76]={fld:"TEXTBLOCKCTACONTABLECODIGO",format:0,grid:0};this.GXValidFnc[78]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Ctacontablecodigo,isvalid:null,fld:"CTACONTABLECODIGO",gxz:"Z193CtaContableCodigo",gxold:"O193CtaContableCodigo",gxvar:"A193CtaContableCodigo",ucs:[],op:[],ip:[78,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A193CtaContableCodigo=a
},v2z:function(a){gx.O.Z193CtaContableCodigo=a},v2c:function(){gx.fn.setControlValue("CTACONTABLECODIGO",gx.O.A193CtaContableCodigo,0)},c2v:function(){gx.O.A193CtaContableCodigo=this.val()},val:function(){return gx.fn.getControlValue("CTACONTABLECODIGO")},nac:function(){return false}};this.GXValidFnc[81]={fld:"TEXTBLOCKMOVMAYORIZADODEBE",format:0,grid:0};this.GXValidFnc[83]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"MOVMAYORIZADODEBE",gxz:"Z223MovMayorizadoDebe",gxold:"O223MovMayorizadoDebe",gxvar:"A223MovMayorizadoDebe",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A223MovMayorizadoDebe=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z223MovMayorizadoDebe=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("MOVMAYORIZADODEBE",gx.O.A223MovMayorizadoDebe,2,".")},c2v:function(){gx.O.A223MovMayorizadoDebe=this.val()},val:function(){return gx.fn.getDecimalValue("MOVMAYORIZADODEBE",",",".")},nac:function(){return false}};this.GXValidFnc[86]={fld:"TEXTBLOCKMOVMAYORIZADOHABER",format:0,grid:0};this.GXValidFnc[88]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"MOVMAYORIZADOHABER",gxz:"Z224MovMayorizadoHaber",gxold:"O224MovMayorizadoHaber",gxvar:"A224MovMayorizadoHaber",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A224MovMayorizadoHaber=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z224MovMayorizadoHaber=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("MOVMAYORIZADOHABER",gx.O.A224MovMayorizadoHaber,2,".")},c2v:function(){gx.O.A224MovMayorizadoHaber=this.val()},val:function(){return gx.fn.getDecimalValue("MOVMAYORIZADOHABER",",",".")},nac:function(){return false}};this.GXValidFnc[91]={fld:"TEXTBLOCKUSUARIOCODIGO",format:0,grid:0};this.GXValidFnc[93]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Usuariocodigo,isvalid:null,fld:"USUARIOCODIGO",gxz:"Z4UsuarioCodigo",gxold:"O4UsuarioCodigo",gxvar:"A4UsuarioCodigo",ucs:[],op:[],ip:[93],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A4UsuarioCodigo=a
},v2z:function(a){gx.O.Z4UsuarioCodigo=a},v2c:function(){gx.fn.setControlValue("USUARIOCODIGO",gx.O.A4UsuarioCodigo,0)},c2v:function(){gx.O.A4UsuarioCodigo=this.val()},val:function(){return gx.fn.getControlValue("USUARIOCODIGO")},nac:function(){return false}};this.GXValidFnc[99]={fld:"PROMPT_41_199",grid:55};this.GXValidFnc[100]={fld:"PROMPT_41_193",grid:55};this.GXValidFnc[101]={fld:"PROMPT_4",grid:55};this.A41ClinicaCodigo="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.A199TipoParCodigo="";
this.Z199TipoParCodigo="";this.O199TipoParCodigo="";this.A217MovMayorizadoId=0;this.Z217MovMayorizadoId=0;this.O217MovMayorizadoId=0;this.A218MovMayorizadoLinea=0;this.Z218MovMayorizadoLinea=0;this.O218MovMayorizadoLinea=0;this.A219MovMayorizadoFecha=gx.date.nullDate();this.Z219MovMayorizadoFecha=gx.date.nullDate();this.O219MovMayorizadoFecha=gx.date.nullDate();this.A220MovMayorizadoHora="";this.Z220MovMayorizadoHora="";this.O220MovMayorizadoHora="";this.A221MovMayorizadoObs="";this.Z221MovMayorizadoObs="";
this.O221MovMayorizadoObs="";this.A222MovMayorizadoReferencia="";this.Z222MovMayorizadoReferencia="";this.O222MovMayorizadoReferencia="";this.A193CtaContableCodigo="";this.Z193CtaContableCodigo="";this.O193CtaContableCodigo="";this.A223MovMayorizadoDebe=0;this.Z223MovMayorizadoDebe=0;this.O223MovMayorizadoDebe=0;this.A224MovMayorizadoHaber=0;this.Z224MovMayorizadoHaber=0;this.O224MovMayorizadoHaber=0;this.A4UsuarioCodigo="";this.Z4UsuarioCodigo="";this.O4UsuarioCodigo="";this.ServerEvents=["e111655_client","e121655_client"];
this.setPrompt("PROMPT_41_199",[38,43]);this.setPrompt("PROMPT_41_193",[38,78]);this.setPrompt("PROMPT_4",[93]);this.EnterCtrl=["BTN_ENTER2","BTN_ENTER2_SEPARATOR","BTN_ENTER"];this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}movimientomayorizado.prototype=new gx.GxObject;gx.setParentObj(new movimientomayorizado());