/*
               File: PartidaEncConversion
        Description: Conversion for table PartidaEnc
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:25.94
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
   public class partidaencconversion : GXProcedure
   {
      public partidaencconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public partidaencconversion( IGxContext context )
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
         partidaencconversion objpartidaencconversion;
         objpartidaencconversion = new partidaencconversion();
         objpartidaencconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpartidaencconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((partidaencconversion)stateInfo).executePrivate();
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
         /* Using cursor PARTIDAENC2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A213PartidaEstdo = PARTIDAENC2_A213PartidaEstdo[0] ;
            A4UsuarioCodigo = PARTIDAENC2_A4UsuarioCodigo[0] ;
            A212PartidaReferencia = PARTIDAENC2_A212PartidaReferencia[0] ;
            A211PartidaMayorizada = PARTIDAENC2_A211PartidaMayorizada[0] ;
            A210PartidaObs = PARTIDAENC2_A210PartidaObs[0] ;
            A209PartidaHora = PARTIDAENC2_A209PartidaHora[0] ;
            A208PartidaFecha = PARTIDAENC2_A208PartidaFecha[0] ;
            A207PartidaId = PARTIDAENC2_A207PartidaId[0] ;
            A199TipoParCodigo = PARTIDAENC2_A199TipoParCodigo[0] ;
            A41ClinicaCodigo = PARTIDAENC2_A41ClinicaCodigo[0] ;
            A40000GXC1 = PARTIDAENC2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0053

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3TipoParCodigo = A199TipoParCodigo ;
            AV4PartidaId = A207PartidaId ;
            AV5PartidaFecha = A208PartidaFecha ;
            AV6PartidaHora = A209PartidaHora ;
            AV7PartidaObs = A210PartidaObs ;
            AV8PartidaMayorizada = A211PartidaMayorizada ;
            AV9PartidaReferencia = A212PartidaReferencia ;
            AV10UsuarioCodigo = A4UsuarioCodigo ;
            AV11PartidaEstdo = A213PartidaEstdo ;
            /* Using cursor PARTIDAENC3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3TipoParCodigo, AV4PartidaId, AV5PartidaFecha, AV6PartidaHora, AV7PartidaObs, AV8PartidaMayorizada, AV9PartidaReferencia, AV10UsuarioCodigo, AV11PartidaEstdo});
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
         PARTIDAENC2_A213PartidaEstdo = new short[1] ;
         PARTIDAENC2_A4UsuarioCodigo = new String[] {""} ;
         PARTIDAENC2_A212PartidaReferencia = new String[] {""} ;
         PARTIDAENC2_A211PartidaMayorizada = new short[1] ;
         PARTIDAENC2_A210PartidaObs = new String[] {""} ;
         PARTIDAENC2_A209PartidaHora = new String[] {""} ;
         PARTIDAENC2_A208PartidaFecha = new DateTime[] {DateTime.MinValue} ;
         PARTIDAENC2_A207PartidaId = new int[1] ;
         PARTIDAENC2_A199TipoParCodigo = new String[] {""} ;
         PARTIDAENC2_A41ClinicaCodigo = new String[] {""} ;
         PARTIDAENC2_A40000GXC1 = new int[1] ;
         A4UsuarioCodigo = "" ;
         A212PartidaReferencia = "" ;
         A210PartidaObs = "" ;
         A209PartidaHora = "" ;
         A208PartidaFecha = DateTime.MinValue ;
         A199TipoParCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3TipoParCodigo = "" ;
         AV5PartidaFecha = DateTime.MinValue ;
         AV6PartidaHora = "" ;
         AV7PartidaObs = "" ;
         AV9PartidaReferencia = "" ;
         AV10UsuarioCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.partidaencconversion__default(),
            new Object[][] {
                new Object[] {
               PARTIDAENC2_A213PartidaEstdo, PARTIDAENC2_A4UsuarioCodigo, PARTIDAENC2_A212PartidaReferencia, PARTIDAENC2_A211PartidaMayorizada, PARTIDAENC2_A210PartidaObs, PARTIDAENC2_A209PartidaHora, PARTIDAENC2_A208PartidaFecha, PARTIDAENC2_A207PartidaId, PARTIDAENC2_A199TipoParCodigo, PARTIDAENC2_A41ClinicaCodigo,
               PARTIDAENC2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A213PartidaEstdo ;
      private short A211PartidaMayorizada ;
      private short AV8PartidaMayorizada ;
      private short AV11PartidaEstdo ;
      private int A207PartidaId ;
      private int A40000GXC1 ;
      private int GIGXA0053 ;
      private int AV2ClinicaCodigo ;
      private int AV4PartidaId ;
      private String scmdbuf ;
      private String A209PartidaHora ;
      private String AV6PartidaHora ;
      private String Gx_emsg ;
      private DateTime A208PartidaFecha ;
      private DateTime AV5PartidaFecha ;
      private String A4UsuarioCodigo ;
      private String A212PartidaReferencia ;
      private String A210PartidaObs ;
      private String A199TipoParCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3TipoParCodigo ;
      private String AV7PartidaObs ;
      private String AV9PartidaReferencia ;
      private String AV10UsuarioCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] PARTIDAENC2_A213PartidaEstdo ;
      private String[] PARTIDAENC2_A4UsuarioCodigo ;
      private String[] PARTIDAENC2_A212PartidaReferencia ;
      private short[] PARTIDAENC2_A211PartidaMayorizada ;
      private String[] PARTIDAENC2_A210PartidaObs ;
      private String[] PARTIDAENC2_A209PartidaHora ;
      private DateTime[] PARTIDAENC2_A208PartidaFecha ;
      private int[] PARTIDAENC2_A207PartidaId ;
      private String[] PARTIDAENC2_A199TipoParCodigo ;
      private String[] PARTIDAENC2_A41ClinicaCodigo ;
      private int[] PARTIDAENC2_A40000GXC1 ;
   }

   public class partidaencconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmPARTIDAENC2 ;
          prmPARTIDAENC2 = new Object[] {
          } ;
          Object[] prmPARTIDAENC3 ;
          prmPARTIDAENC3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV5PartidaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV6PartidaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV7PartidaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AV8PartidaMayorizada",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV9PartidaReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV10UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV11PartidaEstdo",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("PARTIDAENC2", "SELECT [PartidaEstdo], [UsuarioCodigo], [PartidaReferencia], [PartidaMayorizada], [PartidaObs], [PartidaHora], [PartidaFecha], [PartidaId], [TipoParCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [PartidaEnc] ORDER BY [ClinicaCodigo], [TipoParCodigo], [PartidaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPARTIDAENC2,100,0,true,false )
             ,new CursorDef("PARTIDAENC3", "INSERT INTO [GXA0053] ([ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaFecha], [PartidaHora], [PartidaObs], [PartidaMayorizada], [PartidaReferencia], [UsuarioCodigo], [PartidaEstdo]) VALUES (@AV2ClinicaCodigo, @AV3TipoParCodigo, @AV4PartidaId, @AV5PartidaFecha, @AV6PartidaHora, @AV7PartidaObs, @AV8PartidaMayorizada, @AV9PartidaReferencia, @AV10UsuarioCodigo, @AV11PartidaEstdo)", GxErrorMask.GX_NOMASK,prmPARTIDAENC3)
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 8) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((int[]) buf[7])[0] = rslt.getInt(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((int[]) buf[10])[0] = rslt.getInt(11) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (short)parms[9]);
                break;
       }
    }

 }

}
