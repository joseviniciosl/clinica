gx.evt.autoSkip=false;function wp_reversapartida(){this.ServerClass="wp_reversapartida";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.Valid_Clinicacodigo=function(){try{if(gx.fn.currentGridRowImpl(24)===0){return true}var a=gx.util.balloon.getNew("CLINICACODIGO",gx.fn.currentGridRowImpl(24));this.AnyError=0;this.StandaloneModal();this.StandaloneNotModal()}catch(b){}try{if(a==null){return true}return a.show()
}catch(b){}return true};this.Valid_Tipoparcodigo=function(){try{if(gx.fn.currentGridRowImpl(24)===0){return true}var a=gx.util.balloon.getNew("TIPOPARCODIGO",gx.fn.currentGridRowImpl(24));this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e11372_client=function(){this.executeServerEvent("'FIRST'",false)};this.e12372_client=function(){this.executeServerEvent("'PREVIOUS'",false)};this.e13372_client=function(){this.executeServerEvent("'NEXT'",false)};this.e14372_client=function(){this.executeServerEvent("'LAST'",false)
};this.e15372_client=function(){this.executeServerEvent("'REGRESAR'",false)};this.e16372_client=function(){this.executeServerEvent("'ANULAR PARTIDA'",false)};this.e19372_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e20372_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,5,11,14,16,19,21,25,26,27,28,29,30,31];this.GXLastCtrlId=31;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",24,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"wp_reversapartida",[],false,1,true,true,12,false,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
this.Grid1Container.addSingleLineEdit(41,25,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",false,0,false,false);this.Grid1Container.addSingleLineEdit(199,26,"TIPOPARCODIGO","Tipo_Partida","","TipoParCodigo","svchar",0,"px",10,10,"left",null,[],199,"TipoParCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(200,27,"TIPOPARNOMBRE","Nombre","","TipoParNombre","svchar",0,"px",70,70,"left",null,[],200,"TipoParNombre",true,0,false,false);
this.Grid1Container.addSingleLineEdit(207,28,"PARTIDAID","Partida","","PartidaId","int",0,"px",9,9,"right",null,[],207,"PartidaId",true,0,false,false);this.Grid1Container.addSingleLineEdit(208,29,"PARTIDAFECHA","Fecha","","PartidaFecha","date",0,"px",8,8,"right",null,[],208,"PartidaFecha",true,0,false,false);this.Grid1Container.addComboBox(211,30,"PARTIDAMAYORIZADA","Mayorizada","PartidaMayorizada","int",null,0,true,false,0,"px");this.Grid1Container.addComboBox(289,31,"PARTIDAESTADO","Partida Estado","PartidaEstado","int",null,0,true,false,0,"px");
this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[5]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[11]={fld:"TABLE2",grid:0};this.GXValidFnc[14]={fld:"TEXTBLOCK4",format:0,grid:0};this.GXValidFnc[16]={fld:"TEXTBLOCK3",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPARTIDAFECHAD",gxz:"ZV7PartidaFechaD",gxold:"OV7PartidaFechaD",gxvar:"AV7PartidaFechaD",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7PartidaFechaD=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV7PartidaFechaD=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vPARTIDAFECHAD",gx.O.AV7PartidaFechaD,0)},c2v:function(){gx.O.AV7PartidaFechaD=this.val()},val:function(){return gx.fn.getControlValue("vPARTIDAFECHAD")},nac:function(){return false}};this.GXValidFnc[21]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPARTIDAFECHAA",gxz:"ZV8PartidaFechaA",gxold:"OV8PartidaFechaA",gxvar:"AV8PartidaFechaA",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8PartidaFechaA=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV8PartidaFechaA=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vPARTIDAFECHAA",gx.O.AV8PartidaFechaA,0)},c2v:function(){gx.O.AV8PartidaFechaA=this.val()},val:function(){return gx.fn.getControlValue("vPARTIDAFECHAA")},nac:function(){return false}};this.GXValidFnc[25]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:24,gxgrid:this.Grid1Container,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[27],ip:[27,26,25],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(24),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[26]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:24,gxgrid:this.Grid1Container,fnc:this.Valid_Tipoparcodigo,isvalid:null,fld:"TIPOPARCODIGO",gxz:"Z199TipoParCodigo",gxold:"O199TipoParCodigo",gxvar:"A199TipoParCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A199TipoParCodigo=a
},v2z:function(a){gx.O.Z199TipoParCodigo=a},v2c:function(){gx.fn.setGridControlValue("TIPOPARCODIGO",gx.fn.currentGridRowImpl(24),gx.O.A199TipoParCodigo,0)},c2v:function(){gx.O.A199TipoParCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("TIPOPARCODIGO",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[27]={lvl:2,type:"svchar",len:70,dec:0,sign:false,ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"TIPOPARNOMBRE",gxz:"Z200TipoParNombre",gxold:"O200TipoParNombre",gxvar:"A200TipoParNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A200TipoParNombre=a
},v2z:function(a){gx.O.Z200TipoParNombre=a},v2c:function(){gx.fn.setGridControlValue("TIPOPARNOMBRE",gx.fn.currentGridRowImpl(24),gx.O.A200TipoParNombre,0)},c2v:function(){gx.O.A200TipoParNombre=this.val()},val:function(){return gx.fn.getGridControlValue("TIPOPARNOMBRE",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PARTIDAID",gxz:"Z207PartidaId",gxold:"O207PartidaId",gxvar:"A207PartidaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A207PartidaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z207PartidaId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PARTIDAID",gx.fn.currentGridRowImpl(24),gx.O.A207PartidaId,0)},c2v:function(){gx.O.A207PartidaId=this.val()},val:function(){return gx.fn.getGridIntegerValue("PARTIDAID",gx.fn.currentGridRowImpl(24),",")},nac:function(){return false}};this.GXValidFnc[29]={lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PARTIDAFECHA",gxz:"Z208PartidaFecha",gxold:"O208PartidaFecha",gxvar:"A208PartidaFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A208PartidaFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z208PartidaFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("PARTIDAFECHA",gx.fn.currentGridRowImpl(24),gx.O.A208PartidaFecha,0)},c2v:function(){gx.O.A208PartidaFecha=this.val()},val:function(){return gx.fn.getGridControlValue("PARTIDAFECHA",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[30]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PARTIDAMAYORIZADA",gxz:"Z211PartidaMayorizada",gxold:"O211PartidaMayorizada",gxvar:"A211PartidaMayorizada",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A211PartidaMayorizada=gx.num.intval(a)
},v2z:function(a){gx.O.Z211PartidaMayorizada=gx.num.intval(a)},v2c:function(){gx.fn.setGridComboBoxValue("PARTIDAMAYORIZADA",gx.fn.currentGridRowImpl(24),gx.O.A211PartidaMayorizada)},c2v:function(){gx.O.A211PartidaMayorizada=this.val()},val:function(){return gx.fn.getGridIntegerValue("PARTIDAMAYORIZADA",gx.fn.currentGridRowImpl(24),",")},nac:function(){return false}};this.GXValidFnc[31]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:24,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PARTIDAESTADO",gxz:"Z289PartidaEstado",gxold:"O289PartidaEstado",gxvar:"A289PartidaEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A289PartidaEstado=gx.num.intval(a)
},v2z:function(a){gx.O.Z289PartidaEstado=gx.num.intval(a)},v2c:function(){gx.fn.setGridComboBoxValue("PARTIDAESTADO",gx.fn.currentGridRowImpl(24),gx.O.A289PartidaEstado)},c2v:function(){gx.O.A289PartidaEstado=this.val()},val:function(){return gx.fn.getGridIntegerValue("PARTIDAESTADO",gx.fn.currentGridRowImpl(24),",")},nac:function(){return false}};this.AV7PartidaFechaD=gx.date.nullDate();this.ZV7PartidaFechaD=gx.date.nullDate();this.OV7PartidaFechaD=gx.date.nullDate();this.AV8PartidaFechaA=gx.date.nullDate();
this.ZV8PartidaFechaA=gx.date.nullDate();this.OV8PartidaFechaA=gx.date.nullDate();this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z199TipoParCodigo="";this.O199TipoParCodigo="";this.Z200TipoParNombre="";this.O200TipoParNombre="";this.Z207PartidaId=0;this.O207PartidaId=0;this.Z208PartidaFecha=gx.date.nullDate();this.O208PartidaFecha=gx.date.nullDate();this.Z211PartidaMayorizada=0;this.O211PartidaMayorizada=0;this.Z289PartidaEstado=0;this.O289PartidaEstado=0;this.A41ClinicaCodigo="";this.A199TipoParCodigo="";
this.A200TipoParNombre="";this.A207PartidaId=0;this.A208PartidaFecha=gx.date.nullDate();this.A211PartidaMayorizada=0;this.A289PartidaEstado=0;this.ServerEvents=["e11372_client","e12372_client","e13372_client","e14372_client","e15372_client","e16372_client","e19372_client","e20372_client"];this.VarControlMap.AV5ClinicaCodigo={id:"vCLINICACODIGO",grid:0,type:"svchar"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[21]);this.Grid1Container.addRefreshingVar({rfrVar:"AV5ClinicaCodigo"});
this.SetStandaloneVars()}wp_reversapartida.prototype=new gx.GxObject;gx.setParentObj(new wp_reversapartida());