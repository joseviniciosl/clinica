/*
               File: PartidaDetConversion
        Description: Conversion for table PartidaDet
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:25.85
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
   public class partidadetconversion : GXProcedure
   {
      public partidadetconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public partidadetconversion( IGxContext context )
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
         partidadetconversion objpartidadetconversion;
         objpartidadetconversion = new partidadetconversion();
         objpartidadetconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpartidadetconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((partidadetconversion)stateInfo).executePrivate();
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
         /* Using cursor PARTIDADET2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A193CtaContableCodigo = PARTIDADET2_A193CtaContableCodigo[0] ;
            A216PartidaHaber = PARTIDADET2_A216PartidaHaber[0] ;
            A215PartidaDebe = PARTIDADET2_A215PartidaDebe[0] ;
            A214PartidaLinea = PARTIDADET2_A214PartidaLinea[0] ;
            A207PartidaId = PARTIDADET2_A207PartidaId[0] ;
            A199TipoParCodigo = PARTIDADET2_A199TipoParCodigo[0] ;
            A41ClinicaCodigo = PARTIDADET2_A41ClinicaCodigo[0] ;
            A40000GXC1 = PARTIDADET2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0054

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3TipoParCodigo = A199TipoParCodigo ;
            AV4PartidaId = A207PartidaId ;
            AV5PartidaLinea = A214PartidaLinea ;
            AV6PartidaDebe = A215PartidaDebe ;
            AV7PartidaHaber = A216PartidaHaber ;
            AV8CtaContableCodigo = A193CtaContableCodigo ;
            /* Using cursor PARTIDADET3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3TipoParCodigo, AV4PartidaId, AV5PartidaLinea, AV6PartidaDebe, AV7PartidaHaber, AV8CtaContableCodigo});
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
         PARTIDADET2_A193CtaContableCodigo = new String[] {""} ;
         PARTIDADET2_A216PartidaHaber = new decimal[1] ;
         PARTIDADET2_A215PartidaDebe = new decimal[1] ;
         PARTIDADET2_A214PartidaLinea = new short[1] ;
         PARTIDADET2_A207PartidaId = new int[1] ;
         PARTIDADET2_A199TipoParCodigo = new String[] {""} ;
         PARTIDADET2_A41ClinicaCodigo = new String[] {""} ;
         PARTIDADET2_A40000GXC1 = new int[1] ;
         A193CtaContableCodigo = "" ;
         A199TipoParCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3TipoParCodigo = "" ;
         AV8CtaContableCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.partidadetconversion__default(),
            new Object[][] {
                new Object[] {
               PARTIDADET2_A193CtaContableCodigo, PARTIDADET2_A216PartidaHaber, PARTIDADET2_A215PartidaDebe, PARTIDADET2_A214PartidaLinea, PARTIDADET2_A207PartidaId, PARTIDADET2_A199TipoParCodigo, PARTIDADET2_A41ClinicaCodigo, PARTIDADET2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A214PartidaLinea ;
      private short AV5PartidaLinea ;
      private int A207PartidaId ;
      private int A40000GXC1 ;
      private int GIGXA0054 ;
      private int AV2ClinicaCodigo ;
      private int AV4PartidaId ;
      private decimal A216PartidaHaber ;
      private decimal A215PartidaDebe ;
      private decimal AV6PartidaDebe ;
      private decimal AV7PartidaHaber ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A193CtaContableCodigo ;
      private String A199TipoParCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3TipoParCodigo ;
      private String AV8CtaContableCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] PARTIDADET2_A193CtaContableCodigo ;
      private decimal[] PARTIDADET2_A216PartidaHaber ;
      private decimal[] PARTIDADET2_A215PartidaDebe ;
      private short[] PARTIDADET2_A214PartidaLinea ;
      private int[] PARTIDADET2_A207PartidaId ;
      private String[] PARTIDADET2_A199TipoParCodigo ;
      private String[] PARTIDADET2_A41ClinicaCodigo ;
      private int[] PARTIDADET2_A40000GXC1 ;
   }

   public class partidadetconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmPARTIDADET2 ;
          prmPARTIDADET2 = new Object[] {
          } ;
          Object[] prmPARTIDADET3 ;
          prmPARTIDADET3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV5PartidaLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6PartidaDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV7PartidaHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV8CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("PARTIDADET2", "SELECT [CtaContableCodigo], [PartidaHaber], [PartidaDebe], [PartidaLinea], [PartidaId], [TipoParCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [PartidaDet] ORDER BY [ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaLinea] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPARTIDADET2,100,0,true,false )
             ,new CursorDef("PARTIDADET3", "INSERT INTO [GXA0054] ([ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaLinea], [PartidaDebe], [PartidaHaber], [CtaContableCodigo]) VALUES (@AV2ClinicaCodigo, @AV3TipoParCodigo, @AV4PartidaId, @AV5PartidaLinea, @AV6PartidaDebe, @AV7PartidaHaber, @AV8CtaContableCodigo)", GxErrorMask.GX_NOMASK,prmPARTIDADET3)
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((int[]) buf[7])[0] = rslt.getInt(8) ;
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
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
