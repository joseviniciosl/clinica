gx.evt.autoSkip=false;function gx00p0(){this.ServerClass="Gx00P0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV13pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV14pConsultaId=gx.fn.getIntegerValue("vPCONSULTAID",",")};this.e130v2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e140v1_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];
this.GXCtrlIds=[2,8,9,12,14,17,19,22,24,27,29,32,34,37,39,42,44,47,48,52,53,54,55,56,57,58,59,60,61,62,63,64,65,68];this.GXLastCtrlId=68;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",51,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00p0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",52,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(41,53,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",true,0,false,false);
this.Grid1Container.addSingleLineEdit(91,54,"CONSULTAID","Consulta","","ConsultaId","int",0,"px",9,9,"right",null,[],91,"ConsultaId",true,0,false,false);this.Grid1Container.addSingleLineEdit(92,55,"CONSULTAFECHA","Fecha","Seleccionar","ConsultaFecha","date",0,"px",8,8,"right",null,[],92,"ConsultaFecha",true,0,false,false);this.Grid1Container.addSingleLineEdit(93,56,"CONSULTAHORA","Hora","","ConsultaHora","char",0,"px",8,8,"left",null,[],93,"ConsultaHora",true,0,false,false);this.Grid1Container.addSingleLineEdit(67,57,"PACIENTEID","Paciente","","PacienteId","int",0,"px",9,9,"right",null,[],67,"PacienteId",true,0,false,false);
this.Grid1Container.addComboBox(94,58,"CONSULTATIPO","Consulta","ConsultaTipo","int",null,0,true,false,0,"px");this.Grid1Container.addSingleLineEdit(82,59,"ASEGCODIGO","Aseguradora","","AsegCodigo","svchar",0,"px",10,10,"left",null,[],82,"AsegCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(50,60,"CIE10CODIGO","Código","","Cie10Codigo","svchar",0,"px",10,10,"left",null,[],50,"Cie10Codigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(157,61,"CONSULTAEDAD","Edad","","ConsultaEdad","int",0,"px",4,4,"right",null,[],157,"ConsultaEdad",true,0,false,false);
this.Grid1Container.addComboBox(159,62,"CONSULTAESTADO","Estado","ConsultaEstado","int",null,0,true,false,0,"px");this.Grid1Container.addSingleLineEdit(160,63,"CONSULTAFECHAFIN","Finaliza","","ConsultaFechaFin","date",0,"px",8,8,"right",null,[],160,"ConsultaFechaFin",true,0,false,false);this.Grid1Container.addSingleLineEdit(161,64,"CONSULTAHORAFIN","Finaliza","","ConsultaHoraFin","char",0,"px",8,8,"left",null,[],161,"ConsultaHoraFin",true,0,false,false);this.Grid1Container.addSingleLineEdit(19,65,"MEDICOCODIGO","Código","","MedicoCodigo","svchar",0,"px",10,10,"left",null,[],19,"MedicoCodigo",true,0,false,false);
this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCLINICACODIGO",gxz:"ZV6cClinicaCodigo",gxold:"OV6cClinicaCodigo",gxvar:"AV6cClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cClinicaCodigo=a
},v2z:function(a){gx.O.ZV6cClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("vCCLINICACODIGO",gx.O.AV6cClinicaCodigo,0)},c2v:function(){gx.O.AV6cClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKCONSULTAID",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCONSULTAID",gxz:"ZV7cConsultaId",gxold:"OV7cConsultaId",gxvar:"AV7cConsultaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cConsultaId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV7cConsultaId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCCONSULTAID",gx.O.AV7cConsultaId,0)},c2v:function(){gx.O.AV7cConsultaId=this.val()},val:function(){return gx.fn.getIntegerValue("vCCONSULTAID",",")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKCONSULTAFECHA",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCONSULTAFECHA",gxz:"ZV8cConsultaFecha",gxold:"OV8cConsultaFecha",gxvar:"AV8cConsultaFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cConsultaFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV8cConsultaFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vCCONSULTAFECHA",gx.O.AV8cConsultaFecha,0)},c2v:function(){gx.O.AV8cConsultaFecha=this.val()},val:function(){return gx.fn.getControlValue("vCCONSULTAFECHA")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKCONSULTAHORA",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"char",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCONSULTAHORA",gxz:"ZV9cConsultaHora",gxold:"OV9cConsultaHora",gxvar:"AV9cConsultaHora",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cConsultaHora=a
},v2z:function(a){gx.O.ZV9cConsultaHora=a},v2c:function(){gx.fn.setControlValue("vCCONSULTAHORA",gx.O.AV9cConsultaHora,0)},c2v:function(){gx.O.AV9cConsultaHora=this.val()},val:function(){return gx.fn.getControlValue("vCCONSULTAHORA")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TEXTBLOCKPACIENTEID",format:0,grid:0};this.GXValidFnc[34]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPACIENTEID",gxz:"ZV10cPacienteId",gxold:"OV10cPacienteId",gxvar:"AV10cPacienteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10cPacienteId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV10cPacienteId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCPACIENTEID",gx.O.AV10cPacienteId,0)},c2v:function(){gx.O.AV10cPacienteId=this.val()},val:function(){return gx.fn.getIntegerValue("vCPACIENTEID",",")},nac:function(){return false}};this.GXValidFnc[37]={fld:"TEXTBLOCKCONSULTATIPO",format:0,grid:0};this.GXValidFnc[39]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCONSULTATIPO",gxz:"ZV11cConsultaTipo",gxold:"OV11cConsultaTipo",gxvar:"AV11cConsultaTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV11cConsultaTipo=gx.num.intval(a)
},v2z:function(a){gx.O.ZV11cConsultaTipo=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("vCCONSULTATIPO",gx.O.AV11cConsultaTipo)},c2v:function(){gx.O.AV11cConsultaTipo=this.val()},val:function(){return gx.fn.getIntegerValue("vCCONSULTATIPO",",")},nac:function(){return false}};this.GXValidFnc[42]={fld:"TEXTBLOCKASEGCODIGO",format:0,grid:0};this.GXValidFnc[44]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCASEGCODIGO",gxz:"ZV12cAsegCodigo",gxold:"OV12cAsegCodigo",gxvar:"AV12cAsegCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV12cAsegCodigo=a
},v2z:function(a){gx.O.ZV12cAsegCodigo=a},v2c:function(){gx.fn.setControlValue("vCASEGCODIGO",gx.O.AV12cAsegCodigo,0)},c2v:function(){gx.O.AV12cAsegCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCASEGCODIGO")},nac:function(){return false}};this.GXValidFnc[47]={fld:"GROUP2",grid:0};this.GXValidFnc[48]={fld:"TABLE3",grid:0};this.GXValidFnc[52]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[53]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[54]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CONSULTAID",gxz:"Z91ConsultaId",gxold:"O91ConsultaId",gxvar:"A91ConsultaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A91ConsultaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z91ConsultaId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("CONSULTAID",gx.fn.currentGridRowImpl(51),gx.O.A91ConsultaId,0)},c2v:function(){gx.O.A91ConsultaId=this.val()},val:function(){return gx.fn.getGridIntegerValue("CONSULTAID",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[55]={lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CONSULTAFECHA",gxz:"Z92ConsultaFecha",gxold:"O92ConsultaFecha",gxvar:"A92ConsultaFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A92ConsultaFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z92ConsultaFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("CONSULTAFECHA",gx.fn.currentGridRowImpl(51),gx.O.A92ConsultaFecha,0)},c2v:function(){gx.O.A92ConsultaFecha=this.val()},val:function(){return gx.fn.getGridControlValue("CONSULTAFECHA",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[56]={lvl:2,type:"char",len:8,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CONSULTAHORA",gxz:"Z93ConsultaHora",gxold:"O93ConsultaHora",gxvar:"A93ConsultaHora",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A93ConsultaHora=a
},v2z:function(a){gx.O.Z93ConsultaHora=a},v2c:function(){gx.fn.setGridControlValue("CONSULTAHORA",gx.fn.currentGridRowImpl(51),gx.O.A93ConsultaHora,0)},c2v:function(){gx.O.A93ConsultaHora=this.val()},val:function(){return gx.fn.getGridControlValue("CONSULTAHORA",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[57]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PACIENTEID",gxz:"Z67PacienteId",gxold:"O67PacienteId",gxvar:"A67PacienteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A67PacienteId=gx.num.intval(a)
},v2z:function(a){gx.O.Z67PacienteId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PACIENTEID",gx.fn.currentGridRowImpl(51),gx.O.A67PacienteId,0)},c2v:function(){gx.O.A67PacienteId=this.val()},val:function(){return gx.fn.getGridIntegerValue("PACIENTEID",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[58]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CONSULTATIPO",gxz:"Z94ConsultaTipo",gxold:"O94ConsultaTipo",gxvar:"A94ConsultaTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A94ConsultaTipo=gx.num.intval(a)
},v2z:function(a){gx.O.Z94ConsultaTipo=gx.num.intval(a)},v2c:function(){gx.fn.setGridComboBoxValue("CONSULTATIPO",gx.fn.currentGridRowImpl(51),gx.O.A94ConsultaTipo)},c2v:function(){gx.O.A94ConsultaTipo=this.val()},val:function(){return gx.fn.getGridIntegerValue("CONSULTATIPO",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[59]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"ASEGCODIGO",gxz:"Z82AsegCodigo",gxold:"O82AsegCodigo",gxvar:"A82AsegCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A82AsegCodigo=a
},v2z:function(a){gx.O.Z82AsegCodigo=a},v2c:function(){gx.fn.setGridControlValue("ASEGCODIGO",gx.fn.currentGridRowImpl(51),gx.O.A82AsegCodigo,0)},c2v:function(){gx.O.A82AsegCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("ASEGCODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[60]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CIE10CODIGO",gxz:"Z50Cie10Codigo",gxold:"O50Cie10Codigo",gxvar:"A50Cie10Codigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A50Cie10Codigo=a
},v2z:function(a){gx.O.Z50Cie10Codigo=a},v2c:function(){gx.fn.setGridControlValue("CIE10CODIGO",gx.fn.currentGridRowImpl(51),gx.O.A50Cie10Codigo,0)},c2v:function(){gx.O.A50Cie10Codigo=this.val()},val:function(){return gx.fn.getGridControlValue("CIE10CODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[61]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CONSULTAEDAD",gxz:"Z157ConsultaEdad",gxold:"O157ConsultaEdad",gxvar:"A157ConsultaEdad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A157ConsultaEdad=gx.num.intval(a)
},v2z:function(a){gx.O.Z157ConsultaEdad=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("CONSULTAEDAD",gx.fn.currentGridRowImpl(51),gx.O.A157ConsultaEdad,0)},c2v:function(){gx.O.A157ConsultaEdad=this.val()},val:function(){return gx.fn.getGridIntegerValue("CONSULTAEDAD",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[62]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CONSULTAESTADO",gxz:"Z159ConsultaEstado",gxold:"O159ConsultaEstado",gxvar:"A159ConsultaEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A159ConsultaEstado=gx.num.intval(a)
},v2z:function(a){gx.O.Z159ConsultaEstado=gx.num.intval(a)},v2c:function(){gx.fn.setGridComboBoxValue("CONSULTAESTADO",gx.fn.currentGridRowImpl(51),gx.O.A159ConsultaEstado)},c2v:function(){gx.O.A159ConsultaEstado=this.val()},val:function(){return gx.fn.getGridIntegerValue("CONSULTAESTADO",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[63]={lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CONSULTAFECHAFIN",gxz:"Z160ConsultaFechaFin",gxold:"O160ConsultaFechaFin",gxvar:"A160ConsultaFechaFin",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A160ConsultaFechaFin=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z160ConsultaFechaFin=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("CONSULTAFECHAFIN",gx.fn.currentGridRowImpl(51),gx.O.A160ConsultaFechaFin,0)},c2v:function(){gx.O.A160ConsultaFechaFin=this.val()},val:function(){return gx.fn.getGridControlValue("CONSULTAFECHAFIN",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[64]={lvl:2,type:"char",len:8,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CONSULTAHORAFIN",gxz:"Z161ConsultaHoraFin",gxold:"O161ConsultaHoraFin",gxvar:"A161ConsultaHoraFin",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A161ConsultaHoraFin=a
},v2z:function(a){gx.O.Z161ConsultaHoraFin=a},v2c:function(){gx.fn.setGridControlValue("CONSULTAHORAFIN",gx.fn.currentGridRowImpl(51),gx.O.A161ConsultaHoraFin,0)},c2v:function(){gx.O.A161ConsultaHoraFin=this.val()},val:function(){return gx.fn.getGridControlValue("CONSULTAHORAFIN",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[65]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"MEDICOCODIGO",gxz:"Z19MedicoCodigo",gxold:"O19MedicoCodigo",gxvar:"A19MedicoCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A19MedicoCodigo=a
},v2z:function(a){gx.O.Z19MedicoCodigo=a},v2c:function(){gx.fn.setGridControlValue("MEDICOCODIGO",gx.fn.currentGridRowImpl(51),gx.O.A19MedicoCodigo,0)},c2v:function(){gx.O.A19MedicoCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("MEDICOCODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[68]={fld:"TABLE4",grid:0};this.AV6cClinicaCodigo="";this.ZV6cClinicaCodigo="";this.OV6cClinicaCodigo="";this.AV7cConsultaId=0;this.ZV7cConsultaId=0;this.OV7cConsultaId=0;
this.AV8cConsultaFecha=gx.date.nullDate();this.ZV8cConsultaFecha=gx.date.nullDate();this.OV8cConsultaFecha=gx.date.nullDate();this.AV9cConsultaHora="";this.ZV9cConsultaHora="";this.OV9cConsultaHora="";this.AV10cPacienteId=0;this.ZV10cPacienteId=0;this.OV10cPacienteId=0;this.AV11cConsultaTipo=0;this.ZV11cConsultaTipo=0;this.OV11cConsultaTipo=0;this.AV12cAsegCodigo="";this.ZV12cAsegCodigo="";this.OV12cAsegCodigo="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";
this.Z91ConsultaId=0;this.O91ConsultaId=0;this.Z92ConsultaFecha=gx.date.nullDate();this.O92ConsultaFecha=gx.date.nullDate();this.Z93ConsultaHora="";this.O93ConsultaHora="";this.Z67PacienteId=0;this.O67PacienteId=0;this.Z94ConsultaTipo=0;this.O94ConsultaTipo=0;this.Z82AsegCodigo="";this.O82AsegCodigo="";this.Z50Cie10Codigo="";this.O50Cie10Codigo="";this.Z157ConsultaEdad=0;this.O157ConsultaEdad=0;this.Z159ConsultaEstado=0;this.O159ConsultaEstado=0;this.Z160ConsultaFechaFin=gx.date.nullDate();this.O160ConsultaFechaFin=gx.date.nullDate();
this.Z161ConsultaHoraFin="";this.O161ConsultaHoraFin="";this.Z19MedicoCodigo="";this.O19MedicoCodigo="";this.AV13pClinicaCodigo="";this.AV14pConsultaId=0;this.AV5LinkSelection="";this.A41ClinicaCodigo="";this.A91ConsultaId=0;this.A92ConsultaFecha=gx.date.nullDate();this.A93ConsultaHora="";this.A67PacienteId=0;this.A94ConsultaTipo=0;this.A82AsegCodigo="";this.A50Cie10Codigo="";this.A157ConsultaEdad=0;this.A159ConsultaEstado=0;this.A160ConsultaFechaFin=gx.date.nullDate();this.A161ConsultaHoraFin="";
this.A19MedicoCodigo="";this.ServerEvents=["e130v2_client","e140v1_client"];this.VarControlMap.AV13pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV14pConsultaId={id:"vPCONSULTAID",grid:0,type:"int"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[34]);
this.Grid1Container.addRefreshingVar(this.GXValidFnc[39]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[44]);this.SetStandaloneVars()}gx00p0.prototype=new gx.GxObject;gx.setParentObj(new gx00p0());