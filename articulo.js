gx.evt.autoSkip=false;function articulo(){this.ServerClass="Articulo";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.A393ArticuloCalculoTotal=gx.fn.getDecimalValue("ARTICULOCALCULOTOTAL",",",".");this.AV8ClinicaCodigo=gx.fn.getControlValue("vCLINICACODIGO");this.A380UnidadMedidaCodigo=gx.fn.getControlValue("UNIDADMEDIDACODIGO");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Clinicacodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Clinicacodigo",["gx.O.A41ClinicaCodigo","gx.O.A380UnidadMedidaCodigo","gx.O.A27CategoriaCodigo","gx.O.A124SubCategoriaCodigo"],["A27CategoriaCodigo","A124SubCategoriaCodigo"]);
return true};this.Valid_Articulocodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Articulocodigo",["gx.O.AV8ClinicaCodigo","gx.O.A41ClinicaCodigo","gx.O.A30ArticuloCodigo","gx.O.A31ArticuloDescripcion","gx.num.urlDecimal(gx.O.A32ArticuloPrecio,',','.')","gx.num.urlDecimal(gx.O.A60ArticuloCosto,',','.')","gx.O.A33ArticuloTipo","gx.O.A34ArticuloEstado","gx.O.A387ArticuloCirugia","gx.num.urlDecimal(gx.O.A394ArticuloHonorarioCirujano,',','.')","gx.num.urlDecimal(gx.O.A389ArticuloHonorarioAnestesiologo,',','.')","gx.num.urlDecimal(gx.O.A390ArticuloImplante,',','.')","gx.num.urlDecimal(gx.O.A391ArticuloMedicamento,',','.')","gx.num.urlDecimal(gx.O.A392ArticuloOtro,',','.')","gx.O.A27CategoriaCodigo","gx.O.A124SubCategoriaCodigo","gx.O.A380UnidadMedidaCodigo"],["A31ArticuloDescripcion","A32ArticuloPrecio","A60ArticuloCosto","A380UnidadMedidaCodigo","A33ArticuloTipo","A34ArticuloEstado","A387ArticuloCirugia","A394ArticuloHonorarioCirujano","A389ArticuloHonorarioAnestesiologo","A390ArticuloImplante","A391ArticuloMedicamento","A392ArticuloOtro","A27CategoriaCodigo","A124SubCategoriaCodigo","A393ArticuloCalculoTotal","Gx_mode","Z41ClinicaCodigo","Z30ArticuloCodigo","Z31ArticuloDescripcion","Z32ArticuloPrecio","Z60ArticuloCosto","Z380UnidadMedidaCodigo","Z33ArticuloTipo","Z34ArticuloEstado","Z387ArticuloCirugia","Z394ArticuloHonorarioCirujano","Z389ArticuloHonorarioAnestesiologo","Z390ArticuloImplante","Z391ArticuloMedicamento","Z392ArticuloOtro","Z27CategoriaCodigo","Z124SubCategoriaCodigo","Z393ArticuloCalculoTotal",["BTN_DELETE2","Enabled"],["BTN_ENTER2","Enabled"]]);
return true};this.Valid_Articuloprecio=function(){try{var a=gx.util.balloon.getNew("ARTICULOPRECIO");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Categoriacodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Categoriacodigo",["gx.O.A41ClinicaCodigo","gx.O.A27CategoriaCodigo","gx.O.A124SubCategoriaCodigo"],["A124SubCategoriaCodigo"]);return true};this.Valid_Subcategoriacodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Subcategoriacodigo",["gx.O.A41ClinicaCodigo","gx.O.A27CategoriaCodigo","gx.O.A124SubCategoriaCodigo"],[]);
return true};this.Valid_Articulohonorariocirujano=function(){try{var a=gx.util.balloon.getNew("ARTICULOHONORARIOCIRUJANO");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Articulohonorarioanestesiologo=function(){try{var a=gx.util.balloon.getNew("ARTICULOHONORARIOANESTESIOLOGO");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Articuloimplante=function(){try{var a=gx.util.balloon.getNew("ARTICULOIMPLANTE");
this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Articulomedicamento=function(){try{var a=gx.util.balloon.getNew("ARTICULOMEDICAMENTO");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Articulootro=function(){try{var a=gx.util.balloon.getNew("ARTICULOOTRO");this.AnyError=0;try{this.A393ArticuloCalculoTotal=gx.num.subtract(gx.num.subtract(gx.num.subtract(gx.num.subtract(gx.num.subtract(this.A32ArticuloPrecio,this.A394ArticuloHonorarioCirujano),this.A389ArticuloHonorarioAnestesiologo),this.A390ArticuloImplante),this.A391ArticuloMedicamento),this.A392ArticuloOtro)
}catch(b){}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e120812_client=function(){this.executeServerEvent("ENTER",true)};this.e130812_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,51,53,56,58,61,63,66,68,71,73,76,78,81,83,86,88,91,93,96,98,101,103,106,108,117,118];this.GXLastCtrlId=118;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};
this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};
this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};
this.GXValidFnc[38]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[68,63],ip:[68,63,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("CLINICACODIGO",gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CLINICACODIGO")
},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKARTICULOCODIGO",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articulocodigo,isvalid:null,fld:"ARTICULOCODIGO",gxz:"Z30ArticuloCodigo",gxold:"O30ArticuloCodigo",gxvar:"A30ArticuloCodigo",ucs:[],op:[68,63,108,103,98,93,88,83,78,73,58,53,48],ip:[68,63,108,103,98,93,88,83,78,73,58,53,48,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A30ArticuloCodigo=a},v2z:function(a){gx.O.Z30ArticuloCodigo=a
},v2c:function(){gx.fn.setControlValue("ARTICULOCODIGO",gx.O.A30ArticuloCodigo,0)},c2v:function(){gx.O.A30ArticuloCodigo=this.val()},val:function(){return gx.fn.getControlValue("ARTICULOCODIGO")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKARTICULODESCRIPCION",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"ARTICULODESCRIPCION",gxz:"Z31ArticuloDescripcion",gxold:"O31ArticuloDescripcion",gxvar:"A31ArticuloDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A31ArticuloDescripcion=a
},v2z:function(a){gx.O.Z31ArticuloDescripcion=a},v2c:function(){gx.fn.setControlValue("ARTICULODESCRIPCION",gx.O.A31ArticuloDescripcion,0)},c2v:function(){gx.O.A31ArticuloDescripcion=this.val()},val:function(){return gx.fn.getControlValue("ARTICULODESCRIPCION")},nac:function(){return false}};this.GXValidFnc[51]={fld:"TEXTBLOCKARTICULOPRECIO",format:0,grid:0};this.GXValidFnc[53]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articuloprecio,isvalid:null,rgrid:[],fld:"ARTICULOPRECIO",gxz:"Z32ArticuloPrecio",gxold:"O32ArticuloPrecio",gxvar:"A32ArticuloPrecio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A32ArticuloPrecio=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z32ArticuloPrecio=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("ARTICULOPRECIO",gx.O.A32ArticuloPrecio,2,".")},c2v:function(){gx.O.A32ArticuloPrecio=this.val()},val:function(){return gx.fn.getDecimalValue("ARTICULOPRECIO",",",".")},nac:function(){return false}};this.GXValidFnc[56]={fld:"TEXTBLOCKARTICULOCOSTO",format:0,grid:0};this.GXValidFnc[58]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOCOSTO",gxz:"Z60ArticuloCosto",gxold:"O60ArticuloCosto",gxvar:"A60ArticuloCosto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A60ArticuloCosto=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z60ArticuloCosto=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("ARTICULOCOSTO",gx.O.A60ArticuloCosto,2,".")},c2v:function(){gx.O.A60ArticuloCosto=this.val()},val:function(){return gx.fn.getDecimalValue("ARTICULOCOSTO",",",".")},nac:function(){return false}};this.GXValidFnc[61]={fld:"TEXTBLOCKCATEGORIACODIGO",format:0,grid:0};this.GXValidFnc[63]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Categoriacodigo,isvalid:null,fld:"CATEGORIACODIGO",gxz:"Z27CategoriaCodigo",gxold:"O27CategoriaCodigo",gxvar:"A27CategoriaCodigo",ucs:[],op:[68],ip:[68,63,38],nacdep:[],ctrltype:"dyncombo",v2v:function(a){gx.O.A27CategoriaCodigo=a
},v2z:function(a){gx.O.Z27CategoriaCodigo=a},v2c:function(){gx.fn.setComboBoxValue("CATEGORIACODIGO",gx.O.A27CategoriaCodigo)},c2v:function(){gx.O.A27CategoriaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CATEGORIACODIGO")},nac:function(){return false}};this.GXValidFnc[66]={fld:"TEXTBLOCKSUBCATEGORIACODIGO",format:0,grid:0};this.GXValidFnc[68]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Subcategoriacodigo,isvalid:null,fld:"SUBCATEGORIACODIGO",gxz:"Z124SubCategoriaCodigo",gxold:"O124SubCategoriaCodigo",gxvar:"A124SubCategoriaCodigo",ucs:[],op:[],ip:[68,63,38],nacdep:[],ctrltype:"dyncombo",v2v:function(a){gx.O.A124SubCategoriaCodigo=a
},v2z:function(a){gx.O.Z124SubCategoriaCodigo=a},v2c:function(){gx.fn.setComboBoxValue("SUBCATEGORIACODIGO",gx.O.A124SubCategoriaCodigo)},c2v:function(){gx.O.A124SubCategoriaCodigo=this.val()},val:function(){return gx.fn.getControlValue("SUBCATEGORIACODIGO")},nac:function(){return false}};this.GXValidFnc[71]={fld:"TEXTBLOCKARTICULOTIPO",format:0,grid:0};this.GXValidFnc[73]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOTIPO",gxz:"Z33ArticuloTipo",gxold:"O33ArticuloTipo",gxvar:"A33ArticuloTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A33ArticuloTipo=gx.num.intval(a)
},v2z:function(a){gx.O.Z33ArticuloTipo=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("ARTICULOTIPO",gx.O.A33ArticuloTipo)},c2v:function(){gx.O.A33ArticuloTipo=this.val()},val:function(){return gx.fn.getIntegerValue("ARTICULOTIPO",",")},nac:function(){return false}};this.GXValidFnc[76]={fld:"TEXTBLOCKARTICULOESTADO",format:0,grid:0};this.GXValidFnc[78]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOESTADO",gxz:"Z34ArticuloEstado",gxold:"O34ArticuloEstado",gxvar:"A34ArticuloEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A34ArticuloEstado=gx.num.intval(a)
},v2z:function(a){gx.O.Z34ArticuloEstado=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("ARTICULOESTADO",gx.O.A34ArticuloEstado)},c2v:function(){gx.O.A34ArticuloEstado=this.val()},val:function(){return gx.fn.getIntegerValue("ARTICULOESTADO",",")},nac:function(){return false}};this.GXValidFnc[81]={fld:"TEXTBLOCKARTICULOESTADO2",format:0,grid:0};this.GXValidFnc[83]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOCIRUGIA",gxz:"Z387ArticuloCirugia",gxold:"O387ArticuloCirugia",gxvar:"A387ArticuloCirugia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A387ArticuloCirugia=gx.num.intval(a)
},v2z:function(a){gx.O.Z387ArticuloCirugia=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("ARTICULOCIRUGIA",gx.O.A387ArticuloCirugia)},c2v:function(){gx.O.A387ArticuloCirugia=this.val()},val:function(){return gx.fn.getIntegerValue("ARTICULOCIRUGIA",",")},nac:function(){return false}};this.GXValidFnc[86]={fld:"TEXTBLOCKARTICULOESTADO3",format:0,grid:0};this.GXValidFnc[88]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articulohonorariocirujano,isvalid:null,rgrid:[],fld:"ARTICULOHONORARIOCIRUJANO",gxz:"Z394ArticuloHonorarioCirujano",gxold:"O394ArticuloHonorarioCirujano",gxvar:"A394ArticuloHonorarioCirujano",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A394ArticuloHonorarioCirujano=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z394ArticuloHonorarioCirujano=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("ARTICULOHONORARIOCIRUJANO",gx.O.A394ArticuloHonorarioCirujano,2,".")},c2v:function(){gx.O.A394ArticuloHonorarioCirujano=this.val()},val:function(){return gx.fn.getDecimalValue("ARTICULOHONORARIOCIRUJANO",",",".")},nac:function(){return false}};this.GXValidFnc[91]={fld:"TEXTBLOCKARTICULOESTADO4",format:0,grid:0};this.GXValidFnc[93]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articulohonorarioanestesiologo,isvalid:null,rgrid:[],fld:"ARTICULOHONORARIOANESTESIOLOGO",gxz:"Z389ArticuloHonorarioAnestesiologo",gxold:"O389ArticuloHonorarioAnestesiologo",gxvar:"A389ArticuloHonorarioAnestesiologo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A389ArticuloHonorarioAnestesiologo=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z389ArticuloHonorarioAnestesiologo=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("ARTICULOHONORARIOANESTESIOLOGO",gx.O.A389ArticuloHonorarioAnestesiologo,2,".")},c2v:function(){gx.O.A389ArticuloHonorarioAnestesiologo=this.val()},val:function(){return gx.fn.getDecimalValue("ARTICULOHONORARIOANESTESIOLOGO",",",".")},nac:function(){return false}};this.GXValidFnc[96]={fld:"TEXTBLOCKARTICULOESTADO5",format:0,grid:0};this.GXValidFnc[98]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articuloimplante,isvalid:null,rgrid:[],fld:"ARTICULOIMPLANTE",gxz:"Z390ArticuloImplante",gxold:"O390ArticuloImplante",gxvar:"A390ArticuloImplante",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A390ArticuloImplante=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z390ArticuloImplante=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("ARTICULOIMPLANTE",gx.O.A390ArticuloImplante,2,".")},c2v:function(){gx.O.A390ArticuloImplante=this.val()},val:function(){return gx.fn.getDecimalValue("ARTICULOIMPLANTE",",",".")},nac:function(){return false}};this.GXValidFnc[101]={fld:"TEXTBLOCKARTICULOESTADO6",format:0,grid:0};this.GXValidFnc[103]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articulomedicamento,isvalid:null,rgrid:[],fld:"ARTICULOMEDICAMENTO",gxz:"Z391ArticuloMedicamento",gxold:"O391ArticuloMedicamento",gxvar:"A391ArticuloMedicamento",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A391ArticuloMedicamento=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z391ArticuloMedicamento=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("ARTICULOMEDICAMENTO",gx.O.A391ArticuloMedicamento,2,".")},c2v:function(){gx.O.A391ArticuloMedicamento=this.val()},val:function(){return gx.fn.getDecimalValue("ARTICULOMEDICAMENTO",",",".")},nac:function(){return false}};this.GXValidFnc[106]={fld:"TEXTBLOCKARTICULOESTADO7",format:0,grid:0};this.GXValidFnc[108]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articulootro,isvalid:null,rgrid:[],fld:"ARTICULOOTRO",gxz:"Z392ArticuloOtro",gxold:"O392ArticuloOtro",gxvar:"A392ArticuloOtro",ucs:[],op:[],ip:[108,103,98,93,88,53],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A392ArticuloOtro=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z392ArticuloOtro=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("ARTICULOOTRO",gx.O.A392ArticuloOtro,2,".")},c2v:function(){gx.O.A392ArticuloOtro=this.val()},val:function(){return gx.fn.getDecimalValue("ARTICULOOTRO",",",".")},nac:function(){return false}};this.GXValidFnc[117]={fld:"PROMPT_41",grid:12};this.GXValidFnc[118]={fld:"PROMPT_27_124",grid:12};this.A41ClinicaCodigo="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.A30ArticuloCodigo="";
this.Z30ArticuloCodigo="";this.O30ArticuloCodigo="";this.A31ArticuloDescripcion="";this.Z31ArticuloDescripcion="";this.O31ArticuloDescripcion="";this.A32ArticuloPrecio=0;this.Z32ArticuloPrecio=0;this.O32ArticuloPrecio=0;this.A60ArticuloCosto=0;this.Z60ArticuloCosto=0;this.O60ArticuloCosto=0;this.A27CategoriaCodigo="";this.Z27CategoriaCodigo="";this.O27CategoriaCodigo="";this.A124SubCategoriaCodigo="";this.Z124SubCategoriaCodigo="";this.O124SubCategoriaCodigo="";this.A33ArticuloTipo=0;this.Z33ArticuloTipo=0;
this.O33ArticuloTipo=0;this.A34ArticuloEstado=0;this.Z34ArticuloEstado=0;this.O34ArticuloEstado=0;this.A387ArticuloCirugia=0;this.Z387ArticuloCirugia=0;this.O387ArticuloCirugia=0;this.A394ArticuloHonorarioCirujano=0;this.Z394ArticuloHonorarioCirujano=0;this.O394ArticuloHonorarioCirujano=0;this.A389ArticuloHonorarioAnestesiologo=0;this.Z389ArticuloHonorarioAnestesiologo=0;this.O389ArticuloHonorarioAnestesiologo=0;this.A390ArticuloImplante=0;this.Z390ArticuloImplante=0;this.O390ArticuloImplante=0;this.A391ArticuloMedicamento=0;
this.Z391ArticuloMedicamento=0;this.O391ArticuloMedicamento=0;this.A392ArticuloOtro=0;this.Z392ArticuloOtro=0;this.O392ArticuloOtro=0;this.AV7Parametros={};this.AV8ClinicaCodigo="";this.A393ArticuloCalculoTotal=0;this.A380UnidadMedidaCodigo="";this.ServerEvents=["e120812_client","e130812_client"];this.setPrompt("PROMPT_41",[38]);this.setPrompt("PROMPT_27_124",[63,68]);this.EnterCtrl=["BTN_ENTER2","BTN_ENTER2_SEPARATOR","BTN_ENTER"];this.VarControlMap.A393ArticuloCalculoTotal={id:"ARTICULOCALCULOTOTAL",grid:0,type:"decimal"};
this.VarControlMap.AV8ClinicaCodigo={id:"vCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.A380UnidadMedidaCodigo={id:"UNIDADMEDIDACODIGO",grid:0,type:"svchar"};this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}articulo.prototype=new gx.GxObject;gx.setParentObj(new articulo());