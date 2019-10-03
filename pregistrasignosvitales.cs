/*
               File: pRegistraSignosVitales
        Description: Registra Signos Vitales de Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:35.55
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class pregistrasignosvitales : GXProcedure
   {
      public pregistrasignosvitales( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistrasignosvitales( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_ConsultaId ,
                           ref decimal aP2_SignoEstatura ,
                           ref String aP3_SignoEstaturaEn ,
                           ref decimal aP4_SignoFrecCardiaca ,
                           ref decimal aP5_SignoFrecRespiratoria ,
                           ref String aP6_SignoObs ,
                           ref decimal aP7_SignoPeso ,
                           ref String aP8_SignoPesoEn ,
                           ref String aP9_SignoPresionArterial ,
                           ref decimal aP10_SignoTemperatura ,
                           ref String aP11_SignoTemperaturaDe )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         this.AV8SignoEstatura = aP2_SignoEstatura;
         this.AV9SignoEstaturaEn = aP3_SignoEstaturaEn;
         this.AV10SignoFrecCardiaca = aP4_SignoFrecCardiaca;
         this.AV11SignoFrecRespiratoria = aP5_SignoFrecRespiratoria;
         this.AV12SignoObs = aP6_SignoObs;
         this.AV13SignoPeso = aP7_SignoPeso;
         this.AV14SignoPesoEn = aP8_SignoPesoEn;
         this.AV15SignoPresionArterial = aP9_SignoPresionArterial;
         this.AV16SignoTemperatura = aP10_SignoTemperatura;
         this.AV17SignoTemperaturaDe = aP11_SignoTemperaturaDe;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_SignoEstatura=this.AV8SignoEstatura;
         aP3_SignoEstaturaEn=this.AV9SignoEstaturaEn;
         aP4_SignoFrecCardiaca=this.AV10SignoFrecCardiaca;
         aP5_SignoFrecRespiratoria=this.AV11SignoFrecRespiratoria;
         aP6_SignoObs=this.AV12SignoObs;
         aP7_SignoPeso=this.AV13SignoPeso;
         aP8_SignoPesoEn=this.AV14SignoPesoEn;
         aP9_SignoPresionArterial=this.AV15SignoPresionArterial;
         aP10_SignoTemperatura=this.AV16SignoTemperatura;
         aP11_SignoTemperaturaDe=this.AV17SignoTemperaturaDe;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref int aP1_ConsultaId ,
                                ref decimal aP2_SignoEstatura ,
                                ref String aP3_SignoEstaturaEn ,
                                ref decimal aP4_SignoFrecCardiaca ,
                                ref decimal aP5_SignoFrecRespiratoria ,
                                ref String aP6_SignoObs ,
                                ref decimal aP7_SignoPeso ,
                                ref String aP8_SignoPesoEn ,
                                ref String aP9_SignoPresionArterial ,
                                ref decimal aP10_SignoTemperatura )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         this.AV8SignoEstatura = aP2_SignoEstatura;
         this.AV9SignoEstaturaEn = aP3_SignoEstaturaEn;
         this.AV10SignoFrecCardiaca = aP4_SignoFrecCardiaca;
         this.AV11SignoFrecRespiratoria = aP5_SignoFrecRespiratoria;
         this.AV12SignoObs = aP6_SignoObs;
         this.AV13SignoPeso = aP7_SignoPeso;
         this.AV14SignoPesoEn = aP8_SignoPesoEn;
         this.AV15SignoPresionArterial = aP9_SignoPresionArterial;
         this.AV16SignoTemperatura = aP10_SignoTemperatura;
         this.AV17SignoTemperaturaDe = aP11_SignoTemperaturaDe;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_SignoEstatura=this.AV8SignoEstatura;
         aP3_SignoEstaturaEn=this.AV9SignoEstaturaEn;
         aP4_SignoFrecCardiaca=this.AV10SignoFrecCardiaca;
         aP5_SignoFrecRespiratoria=this.AV11SignoFrecRespiratoria;
         aP6_SignoObs=this.AV12SignoObs;
         aP7_SignoPeso=this.AV13SignoPeso;
         aP8_SignoPesoEn=this.AV14SignoPesoEn;
         aP9_SignoPresionArterial=this.AV15SignoPresionArterial;
         aP10_SignoTemperatura=this.AV16SignoTemperatura;
         aP11_SignoTemperaturaDe=this.AV17SignoTemperaturaDe;
         return AV17SignoTemperaturaDe ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_ConsultaId ,
                                 ref decimal aP2_SignoEstatura ,
                                 ref String aP3_SignoEstaturaEn ,
                                 ref decimal aP4_SignoFrecCardiaca ,
                                 ref decimal aP5_SignoFrecRespiratoria ,
                                 ref String aP6_SignoObs ,
                                 ref decimal aP7_SignoPeso ,
                                 ref String aP8_SignoPesoEn ,
                                 ref String aP9_SignoPresionArterial ,
                                 ref decimal aP10_SignoTemperatura ,
                                 ref String aP11_SignoTemperaturaDe )
      {
         pregistrasignosvitales objpregistrasignosvitales;
         objpregistrasignosvitales = new pregistrasignosvitales();
         objpregistrasignosvitales.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistrasignosvitales.A91ConsultaId = aP1_ConsultaId;
         objpregistrasignosvitales.AV8SignoEstatura = aP2_SignoEstatura;
         objpregistrasignosvitales.AV9SignoEstaturaEn = aP3_SignoEstaturaEn;
         objpregistrasignosvitales.AV10SignoFrecCardiaca = aP4_SignoFrecCardiaca;
         objpregistrasignosvitales.AV11SignoFrecRespiratoria = aP5_SignoFrecRespiratoria;
         objpregistrasignosvitales.AV12SignoObs = aP6_SignoObs;
         objpregistrasignosvitales.AV13SignoPeso = aP7_SignoPeso;
         objpregistrasignosvitales.AV14SignoPesoEn = aP8_SignoPesoEn;
         objpregistrasignosvitales.AV15SignoPresionArterial = aP9_SignoPresionArterial;
         objpregistrasignosvitales.AV16SignoTemperatura = aP10_SignoTemperatura;
         objpregistrasignosvitales.AV17SignoTemperaturaDe = aP11_SignoTemperaturaDe;
         objpregistrasignosvitales.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistrasignosvitales);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_SignoEstatura=this.AV8SignoEstatura;
         aP3_SignoEstaturaEn=this.AV9SignoEstaturaEn;
         aP4_SignoFrecCardiaca=this.AV10SignoFrecCardiaca;
         aP5_SignoFrecRespiratoria=this.AV11SignoFrecRespiratoria;
         aP6_SignoObs=this.AV12SignoObs;
         aP7_SignoPeso=this.AV13SignoPeso;
         aP8_SignoPesoEn=this.AV14SignoPesoEn;
         aP9_SignoPresionArterial=this.AV15SignoPresionArterial;
         aP10_SignoTemperatura=this.AV16SignoTemperatura;
         aP11_SignoTemperaturaDe=this.AV17SignoTemperaturaDe;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistrasignosvitales)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /*
            INSERT RECORD ON TABLE ConsultaSigno

         */
         A96SignoLinea = 1 ;
         A97SignoEstatura = AV8SignoEstatura ;
         A98SignoEstaturaEn = AV9SignoEstaturaEn ;
         A99SignoPeso = AV13SignoPeso ;
         A100SignoPesoEn = AV14SignoPesoEn ;
         A101SignoTemperatura = AV16SignoTemperatura ;
         A102SignoTemperaturaDe = AV17SignoTemperaturaDe ;
         A103SignoPresionArterial = AV15SignoPresionArterial ;
         A104SignoFrecCardiaca = AV10SignoFrecCardiaca ;
         A105SignoFrecRespiratoria = AV11SignoFrecRespiratoria ;
         A106SignoFecha = Gx_date ;
         A107SignoHora = Gx_time ;
         A108SignoObs = AV12SignoObs ;
         /* Using cursor P00052 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A91ConsultaId, A96SignoLinea, A97SignoEstatura, A98SignoEstaturaEn, A99SignoPeso, A100SignoPesoEn, A101SignoTemperatura, A102SignoTemperaturaDe, A103SignoPresionArterial, A104SignoFrecCardiaca, A105SignoFrecRespiratoria, A106SignoFecha, A107SignoHora, A108SignoObs});
         pr_default.close(0);
         if ( (pr_default.getStatus(0) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
         }
         else
         {
            context.Gx_err = 0 ;
            Gx_emsg = "" ;
         }
         /* End Insert */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pRegistraSignosVitales");
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         A98SignoEstaturaEn = "" ;
         A100SignoPesoEn = "" ;
         A102SignoTemperaturaDe = "" ;
         A103SignoPresionArterial = "" ;
         A106SignoFecha = DateTime.MinValue ;
         Gx_date = DateTime.MinValue ;
         A107SignoHora = "" ;
         Gx_time = "" ;
         A108SignoObs = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistrasignosvitales__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short A96SignoLinea ;
      private int A91ConsultaId ;
      private int GX_INS26 ;
      private decimal AV8SignoEstatura ;
      private decimal AV10SignoFrecCardiaca ;
      private decimal AV11SignoFrecRespiratoria ;
      private decimal AV13SignoPeso ;
      private decimal AV16SignoTemperatura ;
      private decimal A97SignoEstatura ;
      private decimal A99SignoPeso ;
      private decimal A101SignoTemperatura ;
      private decimal A104SignoFrecCardiaca ;
      private decimal A105SignoFrecRespiratoria ;
      private String A107SignoHora ;
      private String Gx_time ;
      private String Gx_emsg ;
      private DateTime A106SignoFecha ;
      private DateTime Gx_date ;
      private String A41ClinicaCodigo ;
      private String AV9SignoEstaturaEn ;
      private String AV12SignoObs ;
      private String AV14SignoPesoEn ;
      private String AV15SignoPresionArterial ;
      private String AV17SignoTemperaturaDe ;
      private String A98SignoEstaturaEn ;
      private String A100SignoPesoEn ;
      private String A102SignoTemperaturaDe ;
      private String A103SignoPresionArterial ;
      private String A108SignoObs ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_ConsultaId ;
      private decimal aP2_SignoEstatura ;
      private String aP3_SignoEstaturaEn ;
      private decimal aP4_SignoFrecCardiaca ;
      private decimal aP5_SignoFrecRespiratoria ;
      private String aP6_SignoObs ;
      private decimal aP7_SignoPeso ;
      private String aP8_SignoPesoEn ;
      private String aP9_SignoPresionArterial ;
      private decimal aP10_SignoTemperatura ;
      private String aP11_SignoTemperaturaDe ;
      private IDataStoreProvider pr_default ;
   }

   public class pregistrasignosvitales__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00052 ;
          prmP00052 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@SignoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SignoEstatura",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoEstaturaEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@SignoPeso",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoPesoEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@SignoTemperatura",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoTemperaturaDe",SqlDbType.VarChar,2,0} ,
          new Object[] {"@SignoPresionArterial",SqlDbType.VarChar,6,0} ,
          new Object[] {"@SignoFrecCardiaca",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoFrecRespiratoria",SqlDbType.Decimal,8,2} ,
          new Object[] {"@SignoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@SignoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@SignoObs",SqlDbType.VarChar,600,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00052", "INSERT INTO [ConsultaSigno] ([ClinicaCodigo], [ConsultaId], [SignoLinea], [SignoEstatura], [SignoEstaturaEn], [SignoPeso], [SignoPesoEn], [SignoTemperatura], [SignoTemperaturaDe], [SignoPresionArterial], [SignoFrecCardiaca], [SignoFrecRespiratoria], [SignoFecha], [SignoHora], [SignoObs]) VALUES (@ClinicaCodigo, @ConsultaId, @SignoLinea, @SignoEstatura, @SignoEstaturaEn, @SignoPeso, @SignoPesoEn, @SignoTemperatura, @SignoTemperaturaDe, @SignoPresionArterial, @SignoFrecCardiaca, @SignoFrecRespiratoria, @SignoFecha, @SignoHora, @SignoObs)", GxErrorMask.GX_NOMASK,prmP00052)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (decimal)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (decimal)parms[10]);
                stmt.SetParameter(12, (decimal)parms[11]);
                stmt.SetParameter(13, (DateTime)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                break;
       }
    }

 }

}
