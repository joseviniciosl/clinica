gx.evt.autoSkip=false;function categoria(){this.ServerClass="Categoria";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.AV8ClinicaCodigo=gx.fn.getControlValue("vCLINICACODIGO");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Clinicacodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Clinicacodigo",["gx.O.A41ClinicaCodigo"],[]);return true};this.Valid_Categoriacodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Categoriacodigo",["gx.O.AV8ClinicaCodigo","gx.O.A41ClinicaCodigo","gx.O.A27CategoriaCodigo","gx.O.A28CategoriaDescripcion","gx.O.A29CategoriaEstado"],["A28CategoriaDescripcion","A29CategoriaEstado","Gx_mode","Z41ClinicaCodigo","Z27CategoriaCodigo","Z28CategoriaDescripcion","Z29CategoriaEstado","Gridcategoria_subcategoria",["BTN_DELETE2","Enabled"],["BTN_ENTER2","Enabled"]]);
return true};this.Valid_Subcategoriacodigo=function(){try{if(gx.fn.currentGridRowImpl(60)===0){return true}var a=gx.util.balloon.getNew("SUBCATEGORIACODIGO",gx.fn.currentGridRowImpl(60));this.AnyError=0;this.sMode11=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(11,60);this.standaloneModal0711();this.standaloneNotModal0711();if(gx.fn.gridDuplicateKey(61)){a.setError(gx.text.format(gx.getMessage("GXM_1004"),"Sub-Categorías","","","","","","","",""));this.AnyError=1}}catch(b){}try{this.Gx_mode=this.sMode11;
if(a==null){return true}return a.show()}catch(b){}return true};this.standaloneModal0711=function(){try{if(this.Gx_mode!="INS"){gx.fn.setCtrlProperty("SUBCATEGORIACODIGO","Enabled",0)}else{gx.fn.setCtrlProperty("SUBCATEGORIACODIGO","Enabled",1)}}catch(a){}return true};this.standaloneNotModal0711=function(){return true};this.e120710_client=function(){this.executeServerEvent("ENTER",true)};this.e130710_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,51,53,56,59,61,62,68];
this.GXLastCtrlId=68;this.Gridcategoria_subcategoriaContainer=new gx.grid.grid(this,11,"SubCategoria",60,"Gridcategoria_subcategoria","Gridcategoria_subcategoria","Gridcategoria_subcategoriaContainer",this.CmpContext,this.IsMasterPage,"categoria",[124],false,1,false,true,5,false,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Gridcategoria_subcategoriaContainer.addSingleLineEdit(124,61,"SUBCATEGORIACODIGO","Categoría","","SubCategoriaCodigo","svchar",0,"px",10,10,"left",null,[],124,"SubCategoriaCodigo",true,0,false,false);
this.Gridcategoria_subcategoriaContainer.addSingleLineEdit(125,62,"SUBCATEGORIADESCRIPCION","Descripción","","SubCategoriaDescripcion","svchar",0,"px",100,100,"left",null,[],125,"SubCategoriaDescripcion",true,0,false,false);this.setGrid(this.Gridcategoria_subcategoriaContainer);this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};
this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};
this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("CLINICACODIGO",gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKCATEGORIACODIGO",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Categoriacodigo,isvalid:null,fld:"CATEGORIACODIGO",gxz:"Z27CategoriaCodigo",gxold:"O27CategoriaCodigo",gxvar:"A27CategoriaCodigo",ucs:[],op:[53,48],ip:[53,48,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A27CategoriaCodigo=a
},v2z:function(a){gx.O.Z27CategoriaCodigo=a},v2c:function(){gx.fn.setControlValue("CATEGORIACODIGO",gx.O.A27CategoriaCodigo,0)},c2v:function(){gx.O.A27CategoriaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CATEGORIACODIGO")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKCATEGORIADESCRIPCION",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"CATEGORIADESCRIPCION",gxz:"Z28CategoriaDescripcion",gxold:"O28CategoriaDescripcion",gxvar:"A28CategoriaDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A28CategoriaDescripcion=a
},v2z:function(a){gx.O.Z28CategoriaDescripcion=a},v2c:function(){gx.fn.setControlValue("CATEGORIADESCRIPCION",gx.O.A28CategoriaDescripcion,0)},c2v:function(){gx.O.A28CategoriaDescripcion=this.val()},val:function(){return gx.fn.getControlValue("CATEGORIADESCRIPCION")},nac:function(){return false}};this.GXValidFnc[51]={fld:"TEXTBLOCKCATEGORIAESTADO",format:0,grid:0};this.GXValidFnc[53]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CATEGORIAESTADO",gxz:"Z29CategoriaEstado",gxold:"O29CategoriaEstado",gxvar:"A29CategoriaEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A29CategoriaEstado=gx.num.intval(a)
},v2z:function(a){gx.O.Z29CategoriaEstado=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("CATEGORIAESTADO",gx.O.A29CategoriaEstado)},c2v:function(){gx.O.A29CategoriaEstado=this.val()},val:function(){return gx.fn.getIntegerValue("CATEGORIAESTADO",",")},nac:function(){return false}};this.GXValidFnc[56]={fld:"TABLE3",grid:0};this.GXValidFnc[59]={fld:"TITLESUBCATEGORIA",format:0,grid:0};this.GXValidFnc[61]={lvl:11,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:60,gxgrid:this.Gridcategoria_subcategoriaContainer,fnc:this.Valid_Subcategoriacodigo,isvalid:null,fld:"SUBCATEGORIACODIGO",gxz:"Z124SubCategoriaCodigo",gxold:"O124SubCategoriaCodigo",gxvar:"A124SubCategoriaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A124SubCategoriaCodigo=a
},v2z:function(a){gx.O.Z124SubCategoriaCodigo=a},v2c:function(){gx.fn.setGridControlValue("SUBCATEGORIACODIGO",gx.fn.currentGridRowImpl(60),gx.O.A124SubCategoriaCodigo,0)},c2v:function(){gx.O.A124SubCategoriaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("SUBCATEGORIACODIGO",gx.fn.currentGridRowImpl(60))},nac:function(){return false}};this.GXValidFnc[62]={lvl:11,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:60,gxgrid:this.Gridcategoria_subcategoriaContainer,fnc:null,isvalid:null,fld:"SUBCATEGORIADESCRIPCION",gxz:"Z125SubCategoriaDescripcion",gxold:"O125SubCategoriaDescripcion",gxvar:"A125SubCategoriaDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A125SubCategoriaDescripcion=a
},v2z:function(a){gx.O.Z125SubCategoriaDescripcion=a},v2c:function(){gx.fn.setGridControlValue("SUBCATEGORIADESCRIPCION",gx.fn.currentGridRowImpl(60),gx.O.A125SubCategoriaDescripcion,0)},c2v:function(){gx.O.A125SubCategoriaDescripcion=this.val()},val:function(){return gx.fn.getGridControlValue("SUBCATEGORIADESCRIPCION",gx.fn.currentGridRowImpl(60))},nac:function(){return false}};this.GXValidFnc[68]={fld:"PROMPT_41",grid:10};this.A41ClinicaCodigo="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";
this.A27CategoriaCodigo="";this.Z27CategoriaCodigo="";this.O27CategoriaCodigo="";this.A28CategoriaDescripcion="";this.Z28CategoriaDescripcion="";this.O28CategoriaDescripcion="";this.A29CategoriaEstado=0;this.Z29CategoriaEstado=0;this.O29CategoriaEstado=0;this.Z124SubCategoriaCodigo="";this.O124SubCategoriaCodigo="";this.Z125SubCategoriaDescripcion="";this.O125SubCategoriaDescripcion="";this.A124SubCategoriaCodigo="";this.A125SubCategoriaDescripcion="";this.AV7Parametros={};this.AV8ClinicaCodigo="";
this.ServerEvents=["e120710_client","e130710_client"];this.setPrompt("PROMPT_41",[38]);this.EnterCtrl=["BTN_ENTER2","BTN_ENTER2_SEPARATOR","BTN_ENTER"];this.VarControlMap.AV8ClinicaCodigo={id:"vCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}categoria.prototype=new gx.GxObject;gx.setParentObj(new categoria());