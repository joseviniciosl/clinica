/*
               File: ConsultaSignoConversion
        Description: Conversion for table ConsultaSigno
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:24.29
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class consultasignoconversion : GXProcedure
   {
      public consultasignoconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public consultasignoconversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         consultasignoconversion objconsultasignoconversion;
         objconsultasignoconversion = new consultasignoconversion();
         objconsultasignoconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objconsultasignoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((consultasignoconversion)stateInfo).executePrivate();
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
         /* Using cursor CONSULTASI2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A108SignoObs = CONSULTASI2_A108SignoObs[0] ;
            A107SignoHora = CONSULTASI2_A107SignoHora[0] ;
            A106SignoFecha = CONSULTASI2_A106SignoFecha[0] ;
            A105SignoFrecRespiratoria = CONSULTASI2_A105SignoFrecRespiratoria[0] ;
            A104SignoFrecCardiaca = CONSULTASI2_A104SignoFrecCardiaca[0] ;
            A103SignoPresionArterial = CONSULTASI2_A103SignoPresionArterial[0] ;
            A102SignoTemperaturaDe = CONSULTASI2_A102SignoTemperaturaDe[0] ;
            A101SignoTemperatura = CONSULTASI2_A101SignoTemperatura[0] ;
            A100SignoPesoEn = CONSULTASI2_A100SignoPesoEn[0] ;
            A99SignoPeso = CONSULTASI2_A99SignoPeso[0] ;
            A98SignoEstaturaEn = CONSULTASI2_A98SignoEstaturaEn[0] ;
            A97SignoEstatura = CONSULTASI2_A97SignoEstatura[0] ;
            A96SignoLinea = CONSULTASI2_A96SignoLinea[0] ;
            A91ConsultaId = CONSULTASI2_A91ConsultaId[0] ;
            A41ClinicaCodigo = CONSULTASI2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CONSULTASI2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0026

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3ConsultaId = A91ConsultaId ;
            AV4SignoLinea = A96SignoLinea ;
            AV5SignoEstatura = A97SignoEstatura ;
            AV6SignoEstaturaEn = A98SignoEstaturaEn ;
            AV7SignoPeso = A99SignoPeso ;
            AV8SignoPesoEn = A100SignoPesoEn ;
            AV9SignoTemperatura = A101SignoTemperatura ;
            AV10SignoTemperaturaDe = A102SignoTemperaturaDe ;
            AV11SignoPresionArterial = A103SignoPresionArterial ;
            AV12SignoFrecCardiaca = A104SignoFrecCardiaca ;
            AV13SignoFrecRespiratoria = A105SignoFrecRespiratoria ;
            AV14SignoFecha = A106SignoFecha ;
            AV15SignoHora = A107SignoHora ;
            AV16SignoObs = A108SignoObs ;
            /* Using cursor CONSULTASI3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3ConsultaId, AV4SignoLinea, AV5SignoEstatura, AV6SignoEstaturaEn, AV7SignoPeso, AV8SignoPesoEn, AV9SignoTemperatura, AV10SignoTemperaturaDe, AV11SignoPresionArterial, AV12SignoFrecCardiaca, AV13SignoFrecRespiratoria, AV14SignoFecha, AV15SignoHora, AV16SignoObs});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void cleanup( )
      {
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
         scmdbuf = "" ;
         CONSULTASI2_A108SignoObs = new String[] {""} ;
         CONSULTASI2_A107SignoHora = new String[] {""} ;
         CONSULTASI2_A106SignoFecha = new DateTime[] {DateTime.MinValue} ;
         CONSULTASI2_A105SignoFrecRespiratoria = new decimal[1] ;
         CONSULTASI2_A104SignoFrecCardiaca = new decimal[1] ;
         CONSULTASI2_A103SignoPresionArterial = new String[] {""} ;
         CONSULTASI2_A102SignoTemperaturaDe = new String[] {""} ;
         CONSULTASI2_A101SignoTemperatura = new decimal[1] ;
         CONSULTASI2_A100SignoPesoEn = new String[] {""} ;
         CONSULTASI2_A99SignoPeso = new decimal[1] ;
         CONSULTASI2_A98SignoEstaturaEn = new String[] {""} ;
         CONSULTASI2_A97SignoEstatura = new decimal[1] ;
         CONSULTASI2_A96SignoLinea = new short[1] ;
         CONSULTASI2_A91ConsultaId = new int[1] ;
         CONSULTASI2_A41ClinicaCodigo = new String[] {""} ;
         CONSULTASI2_A40000GXC1 = new int[1] ;
         A108SignoObs = "" ;
         A107SignoHora = "" ;
         A106SignoFecha = DateTime.MinValue ;
         A103SignoPresionArterial = "" ;
         A102SignoTemperaturaDe = "" ;
         A100SignoPesoEn = "" ;
         A98SignoEstaturaEn = "" ;
         A41ClinicaCodigo = "" ;
         AV6SignoEstaturaEn = "" ;
         AV8SignoPesoEn = "" ;
         AV10SignoTemperaturaDe = "" ;
         AV11SignoPresionArterial = "" ;
         AV14SignoFecha = DateTime.MinValue ;
         AV15SignoHora = "" ;
         AV16SignoObs = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.consultasignoconversion__default(),
            new Object[][] {
                new Object[] {
               CONSULTASI2_A108SignoObs, CONSULTASI2_A107SignoHora, CONSULTASI2_A106SignoFecha, CONSULTASI2_A105SignoFrecRespiratoria, CONSULTASI2_A104SignoFrecCardiaca, CONSULTASI2_A103SignoPresionArterial, CONSULTASI2_A102SignoTemperaturaDe, CONSULTASI2_A101SignoTemperatura, CONSULTASI2_A100SignoPesoEn, CONSULTASI2_A99SignoPeso,
               CONSULTASI2_A98SignoEstaturaEn, CONSULTASI2_A97SignoEstatura, CONSULTASI2_A96SignoLinea, CONSULTASI2_A91ConsultaId, CONSULTASI2_A41ClinicaCodigo, CONSULTASI2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A96SignoLinea ;
      private short AV4SignoLinea ;
      private int A91ConsultaId ;
      private int A40000GXC1 ;
      private int GIGXA0026 ;
      private int AV2ClinicaCodigo ;
      private int AV3ConsultaId ;
      private decimal A105SignoFrecRespiratoria ;
      private decimal A104SignoFrecCardiaca ;
      private decimal A101SignoTemperatura ;
      private decimal A99SignoPeso ;
      private decimal A97SignoEstatura ;
      private decimal AV5SignoEstatura ;
      private decimal AV7SignoPeso ;
      private decimal AV9SignoTemperatura ;
      private decimal AV12SignoFrecCardiaca ;
      private decimal AV13SignoFrecRespiratoria ;
      private String scmdbuf ;
      private String A107SignoHora ;
      private String AV15SignoHora ;
      private String Gx_emsg ;
      private DateTime A106SignoFecha ;
      private DateTime AV14SignoFecha ;
      private String A108SignoObs ;
      private String A103SignoPresionArterial ;
      private String A102SignoTemperaturaDe ;
      private String A100SignoPesoEn ;
      private String A98SignoEstaturaEn ;
      private String A41ClinicaCodigo ;
      private String AV6SignoEstaturaEn ;
      private String AV8SignoPesoEn ;
      private String AV10SignoTemperaturaDe ;
      private String AV11SignoPresionArterial ;
      private String AV16SignoObs ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] CONSULTASI2_A108SignoObs ;
      private String[] CONSULTASI2_A107SignoHora ;
      private DateTime[] CONSULTASI2_A106SignoFecha ;
      private decimal[] CONSULTASI2_A105SignoFrecRespiratoria ;
      private decimal[] CONSULTASI2_A104SignoFrecCardiaca ;
      private String[] CONSULTASI2_A103SignoPresionArterial ;
      private String[] CONSULTASI2_A102SignoTemperaturaDe ;
      private decimal[] CONSULTASI2_A101SignoTemperatura ;
      private String[] CONSULTASI2_A100SignoPesoEn ;
      private decimal[] CONSULTASI2_A99SignoPeso ;
      private String[] CONSULTASI2_A98SignoEstaturaEn ;
      private decimal[] CONSULTASI2_A97SignoEstatura ;
      private short[] CONSULTASI2_A96SignoLinea ;
      private int[] CONSULTASI2_A91ConsultaId ;
      private String[] CONSULTASI2_A41ClinicaCodigo ;
      private int[] CONSULTASI2_A40000GXC1 ;
   }

   public class consultasignoconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmCONSULTASI2 ;
          prmCONSULTASI2 = new Object[] {
          } ;
          Object[] prmCONSULTASI3 ;
          prmCONSULTASI3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4SignoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5SignoEstatura",SqlDbType.Decimal,8,2} ,
          new Object[] {"@AV6SignoEstaturaEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV7SignoPeso",SqlDbType.Decimal,8,2} ,
          new Object[] {"@AV8SignoPesoEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV9SignoTemperatura",SqlDbType.Decimal,8,2} ,
          new Object[] {"@AV10SignoTemperaturaDe",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV11SignoPresionArterial",SqlDbType.VarChar,6,0} ,
          new Object[] {"@AV12SignoFrecCardiaca",SqlDbType.Decimal,8,2} ,
          new Object[] {"@AV13SignoFrecRespiratoria",SqlDbType.Decimal,8,2} ,
          new Object[] {"@AV14SignoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15SignoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV16SignoObs",SqlDbType.VarChar,600,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CONSULTASI2", "SELECT [SignoObs], [SignoHora], [SignoFecha], [SignoFrecRespiratoria], [SignoFrecCardiaca], [SignoPresionArterial], [SignoTemperaturaDe], [SignoTemperatura], [SignoPesoEn], [SignoPeso], [SignoEstaturaEn], [SignoEstatura], [SignoLinea], [ConsultaId], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [ConsultaSigno] ORDER BY [ClinicaCodigo], [ConsultaId], [SignoLinea] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCONSULTASI2,100,0,true,false )
             ,new CursorDef("CONSULTASI3", "INSERT INTO [GXA0026] ([ClinicaCodigo], [ConsultaId], [SignoLinea], [SignoEstatura], [SignoEstaturaEn], [SignoPeso], [SignoPesoEn], [SignoTemperatura], [SignoTemperaturaDe], [SignoPresionArterial], [SignoFrecCardiaca], [SignoFrecRespiratoria], [SignoFecha], [SignoHora], [SignoObs]) VALUES (@AV2ClinicaCodigo, @AV3ConsultaId, @AV4SignoLinea, @AV5SignoEstatura, @AV6SignoEstaturaEn, @AV7SignoPeso, @AV8SignoPesoEn, @AV9SignoTemperatura, @AV10SignoTemperaturaDe, @AV11SignoPresionArterial, @AV12SignoFrecCardiaca, @AV13SignoFrecRespiratoria, @AV14SignoFecha, @AV15SignoHora, @AV16SignoObs)", GxErrorMask.GX_NOMASK,prmCONSULTASI3)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 8) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((decimal[]) buf[11])[0] = rslt.getDecimal(12) ;
                ((short[]) buf[12])[0] = rslt.getShort(13) ;
                ((int[]) buf[13])[0] = rslt.getInt(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((int[]) buf[15])[0] = rslt.getInt(16) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
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
