gx.evt.autoSkip=false;function wp_paciente(){this.ServerClass="wp_paciente";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e111e2_client=function(){this.executeServerEvent("'FIRST'",false)};this.e121e2_client=function(){this.executeServerEvent("'PREVIOUS'",false)};this.e131e2_client=function(){this.executeServerEvent("'NEXT'",false)};this.e141e2_client=function(){this.executeServerEvent("'LAST'",false)
};this.e151e2_client=function(){this.executeServerEvent("'REGRESAR'",false)};this.e161e2_client=function(){this.executeServerEvent("'NUEVO PACIENTE'",false)};this.e171e2_client=function(){this.executeServerEvent("'MODIFICA'",true)};this.e181e2_client=function(){this.executeServerEvent("'NUEVA CONSULTA'",false)};this.e211e2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e221e2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,5,11,14,16,18,20,22,25,27,29,31,33,37,38,39,40,41,42,43,44,45];
this.GXLastCtrlId=45;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",36,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"wp_paciente",[],false,1,true,true,12,false,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addSingleLineEdit(41,37,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",false,0,false,false);this.Grid1Container.addSingleLineEdit(67,38,"PACIENTEID","Paciente","","PacienteId","int",0,"px",9,9,"right","e171e2_client",[],67,"PacienteId",true,0,false,false);
this.Grid1Container.addSingleLineEdit(68,39,"PACIENTENOMBRE1","Primer Nombre","","PacienteNombre1","svchar",0,"px",70,70,"left",null,[],68,"PacienteNombre1",true,0,false,false);this.Grid1Container.addSingleLineEdit(69,40,"PACIENTENOMBRE2","Segundo Nombre","","PacienteNombre2","svchar",0,"px",70,70,"left",null,[],69,"PacienteNombre2",true,0,false,false);this.Grid1Container.addSingleLineEdit(70,41,"PACIENTEAPELLIDO1","Primer Apellido","","PacienteApellido1","svchar",0,"px",30,30,"left",null,[],70,"PacienteApellido1",true,0,false,false);
this.Grid1Container.addSingleLineEdit(71,42,"PACIENTEAPELLIDO2","Segundo Apellido","","PacienteApellido2","svchar",0,"px",30,30,"left",null,[],71,"PacienteApellido2",true,0,false,false);this.Grid1Container.addSingleLineEdit(72,43,"PACIENTEAPELLIDO3","Apellido de Casada","","PacienteApellido3","svchar",0,"px",30,30,"left",null,[],72,"PacienteApellido3",true,0,false,false);this.Grid1Container.addSingleLineEdit(74,44,"PACIENTENACIMIENTO","Fecha_Nacimiento","","PacienteNacimiento","date",0,"px",8,8,"right",null,[],74,"PacienteNacimiento",true,0,false,false);
this.Grid1Container.addComboBox(326,45,"PACIENTESEXO","Paciente Sexo","PacienteSexo","svchar",null,0,true,false,0,"px");this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[5]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[11]={fld:"TABLE2",grid:0};this.GXValidFnc[14]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[16]={fld:"TEXTBLOCK3",format:0,grid:0};this.GXValidFnc[18]={fld:"TEXTBLOCK4",format:0,grid:0};this.GXValidFnc[20]={fld:"TEXTBLOCK5",format:0,grid:0};
this.GXValidFnc[22]={fld:"TEXTBLOCK6",format:0,grid:0};this.GXValidFnc[25]={lvl:0,type:"svchar",len:70,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTENOMBRE1",gxz:"ZV7PacienteNombre1",gxold:"OV7PacienteNombre1",gxvar:"AV7PacienteNombre1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7PacienteNombre1=a},v2z:function(a){gx.O.ZV7PacienteNombre1=a},v2c:function(){gx.fn.setControlValue("vPACIENTENOMBRE1",gx.O.AV7PacienteNombre1,0)},c2v:function(){gx.O.AV7PacienteNombre1=this.val()
},val:function(){return gx.fn.getControlValue("vPACIENTENOMBRE1")},nac:function(){return false}};this.GXValidFnc[27]={lvl:0,type:"svchar",len:70,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTENOMBRE2",gxz:"ZV8PacienteNombre2",gxold:"OV8PacienteNombre2",gxvar:"AV8PacienteNombre2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8PacienteNombre2=a},v2z:function(a){gx.O.ZV8PacienteNombre2=a},v2c:function(){gx.fn.setControlValue("vPACIENTENOMBRE2",gx.O.AV8PacienteNombre2,0)
},c2v:function(){gx.O.AV8PacienteNombre2=this.val()},val:function(){return gx.fn.getControlValue("vPACIENTENOMBRE2")},nac:function(){return false}};this.GXValidFnc[29]={lvl:0,type:"svchar",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTEAPELLIDO1",gxz:"ZV9PacienteApellido1",gxold:"OV9PacienteApellido1",gxvar:"AV9PacienteApellido1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9PacienteApellido1=a},v2z:function(a){gx.O.ZV9PacienteApellido1=a
},v2c:function(){gx.fn.setControlValue("vPACIENTEAPELLIDO1",gx.O.AV9PacienteApellido1,0)},c2v:function(){gx.O.AV9PacienteApellido1=this.val()},val:function(){return gx.fn.getControlValue("vPACIENTEAPELLIDO1")},nac:function(){return false}};this.GXValidFnc[31]={lvl:0,type:"svchar",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTEAPELLIDO2",gxz:"ZV10PacienteApellido2",gxold:"OV10PacienteApellido2",gxvar:"AV10PacienteApellido2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10PacienteApellido2=a
},v2z:function(a){gx.O.ZV10PacienteApellido2=a},v2c:function(){gx.fn.setControlValue("vPACIENTEAPELLIDO2",gx.O.AV10PacienteApellido2,0)},c2v:function(){gx.O.AV10PacienteApellido2=this.val()},val:function(){return gx.fn.getControlValue("vPACIENTEAPELLIDO2")},nac:function(){return false}};this.GXValidFnc[33]={lvl:0,type:"svchar",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTEAPELLIDO3",gxz:"ZV11PacienteApellido3",gxold:"OV11PacienteApellido3",gxvar:"AV11PacienteApellido3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11PacienteApellido3=a
},v2z:function(a){gx.O.ZV11PacienteApellido3=a},v2c:function(){gx.fn.setControlValue("vPACIENTEAPELLIDO3",gx.O.AV11PacienteApellido3,0)},c2v:function(){gx.O.AV11PacienteApellido3=this.val()},val:function(){return gx.fn.getControlValue("vPACIENTEAPELLIDO3")},nac:function(){return false}};this.GXValidFnc[37]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(36),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[38]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PACIENTEID",gxz:"Z67PacienteId",gxold:"O67PacienteId",gxvar:"A67PacienteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A67PacienteId=gx.num.intval(a)
},v2z:function(a){gx.O.Z67PacienteId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PACIENTEID",gx.fn.currentGridRowImpl(36),gx.O.A67PacienteId,0)},c2v:function(){gx.O.A67PacienteId=this.val()},val:function(){return gx.fn.getGridIntegerValue("PACIENTEID",gx.fn.currentGridRowImpl(36),",")},nac:function(){return false}};this.GXValidFnc[39]={lvl:2,type:"svchar",len:70,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PACIENTENOMBRE1",gxz:"Z68PacienteNombre1",gxold:"O68PacienteNombre1",gxvar:"A68PacienteNombre1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A68PacienteNombre1=a
},v2z:function(a){gx.O.Z68PacienteNombre1=a},v2c:function(){gx.fn.setGridControlValue("PACIENTENOMBRE1",gx.fn.currentGridRowImpl(36),gx.O.A68PacienteNombre1,0)},c2v:function(){gx.O.A68PacienteNombre1=this.val()},val:function(){return gx.fn.getGridControlValue("PACIENTENOMBRE1",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[40]={lvl:2,type:"svchar",len:70,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PACIENTENOMBRE2",gxz:"Z69PacienteNombre2",gxold:"O69PacienteNombre2",gxvar:"A69PacienteNombre2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A69PacienteNombre2=a
},v2z:function(a){gx.O.Z69PacienteNombre2=a},v2c:function(){gx.fn.setGridControlValue("PACIENTENOMBRE2",gx.fn.currentGridRowImpl(36),gx.O.A69PacienteNombre2,0)},c2v:function(){gx.O.A69PacienteNombre2=this.val()},val:function(){return gx.fn.getGridControlValue("PACIENTENOMBRE2",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[41]={lvl:2,type:"svchar",len:30,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PACIENTEAPELLIDO1",gxz:"Z70PacienteApellido1",gxold:"O70PacienteApellido1",gxvar:"A70PacienteApellido1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A70PacienteApellido1=a
},v2z:function(a){gx.O.Z70PacienteApellido1=a},v2c:function(){gx.fn.setGridControlValue("PACIENTEAPELLIDO1",gx.fn.currentGridRowImpl(36),gx.O.A70PacienteApellido1,0)},c2v:function(){gx.O.A70PacienteApellido1=this.val()},val:function(){return gx.fn.getGridControlValue("PACIENTEAPELLIDO1",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[42]={lvl:2,type:"svchar",len:30,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PACIENTEAPELLIDO2",gxz:"Z71PacienteApellido2",gxold:"O71PacienteApellido2",gxvar:"A71PacienteApellido2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A71PacienteApellido2=a
},v2z:function(a){gx.O.Z71PacienteApellido2=a},v2c:function(){gx.fn.setGridControlValue("PACIENTEAPELLIDO2",gx.fn.currentGridRowImpl(36),gx.O.A71PacienteApellido2,0)},c2v:function(){gx.O.A71PacienteApellido2=this.val()},val:function(){return gx.fn.getGridControlValue("PACIENTEAPELLIDO2",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[43]={lvl:2,type:"svchar",len:30,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PACIENTEAPELLIDO3",gxz:"Z72PacienteApellido3",gxold:"O72PacienteApellido3",gxvar:"A72PacienteApellido3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A72PacienteApellido3=a
},v2z:function(a){gx.O.Z72PacienteApellido3=a},v2c:function(){gx.fn.setGridControlValue("PACIENTEAPELLIDO3",gx.fn.currentGridRowImpl(36),gx.O.A72PacienteApellido3,0)},c2v:function(){gx.O.A72PacienteApellido3=this.val()},val:function(){return gx.fn.getGridControlValue("PACIENTEAPELLIDO3",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[44]={lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PACIENTENACIMIENTO",gxz:"Z74PacienteNacimiento",gxold:"O74PacienteNacimiento",gxvar:"A74PacienteNacimiento",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A74PacienteNacimiento=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z74PacienteNacimiento=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("PACIENTENACIMIENTO",gx.fn.currentGridRowImpl(36),gx.O.A74PacienteNacimiento,0)},c2v:function(){gx.O.A74PacienteNacimiento=this.val()},val:function(){return gx.fn.getGridControlValue("PACIENTENACIMIENTO",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[45]={lvl:2,type:"svchar",len:1,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PACIENTESEXO",gxz:"Z326PacienteSexo",gxold:"O326PacienteSexo",gxvar:"A326PacienteSexo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A326PacienteSexo=a
},v2z:function(a){gx.O.Z326PacienteSexo=a},v2c:function(){gx.fn.setGridComboBoxValue("PACIENTESEXO",gx.fn.currentGridRowImpl(36),gx.O.A326PacienteSexo)},c2v:function(){gx.O.A326PacienteSexo=this.val()},val:function(){return gx.fn.getGridControlValue("PACIENTESEXO",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.AV7PacienteNombre1="";this.ZV7PacienteNombre1="";this.OV7PacienteNombre1="";this.AV8PacienteNombre2="";this.ZV8PacienteNombre2="";this.OV8PacienteNombre2="";this.AV9PacienteApellido1="";
this.ZV9PacienteApellido1="";this.OV9PacienteApellido1="";this.AV10PacienteApellido2="";this.ZV10PacienteApellido2="";this.OV10PacienteApellido2="";this.AV11PacienteApellido3="";this.ZV11PacienteApellido3="";this.OV11PacienteApellido3="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z67PacienteId=0;this.O67PacienteId=0;this.Z68PacienteNombre1="";this.O68PacienteNombre1="";this.Z69PacienteNombre2="";this.O69PacienteNombre2="";this.Z70PacienteApellido1="";this.O70PacienteApellido1="";this.Z71PacienteApellido2="";
this.O71PacienteApellido2="";this.Z72PacienteApellido3="";this.O72PacienteApellido3="";this.Z74PacienteNacimiento=gx.date.nullDate();this.O74PacienteNacimiento=gx.date.nullDate();this.Z326PacienteSexo="";this.O326PacienteSexo="";this.A41ClinicaCodigo="";this.A67PacienteId=0;this.A68PacienteNombre1="";this.A69PacienteNombre2="";this.A70PacienteApellido1="";this.A71PacienteApellido2="";this.A72PacienteApellido3="";this.A74PacienteNacimiento=gx.date.nullDate();this.A326PacienteSexo="";this.ServerEvents=["e111e2_client","e121e2_client","e131e2_client","e141e2_client","e151e2_client","e161e2_client","e171e2_client","e181e2_client","e211e2_client","e221e2_client"];
this.VarControlMap.AV6ClinicaCodigo={id:"vCLINICACODIGO",grid:0,type:"svchar"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[25]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[27]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[31]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[33]);this.Grid1Container.addRefreshingVar({rfrVar:"AV6ClinicaCodigo"});this.SetStandaloneVars()}wp_paciente.prototype=new gx.GxObject;gx.setParentObj(new wp_paciente());