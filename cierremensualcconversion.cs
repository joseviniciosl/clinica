/*
               File: CierreMensualCConversion
        Description: Conversion for table CierreMensualC
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:23.80
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
   public class cierremensualcconversion : GXProcedure
   {
      public cierremensualcconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public cierremensualcconversion( IGxContext context )
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
         cierremensualcconversion objcierremensualcconversion;
         objcierremensualcconversion = new cierremensualcconversion();
         objcierremensualcconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcierremensualcconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cierremensualcconversion)stateInfo).executePrivate();
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
         /* Using cursor CIERREMENS2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A228CierreMCHaber = CIERREMENS2_A228CierreMCHaber[0] ;
            A227CierreMCDebe = CIERREMENS2_A227CierreMCDebe[0] ;
            A193CtaContableCodigo = CIERREMENS2_A193CtaContableCodigo[0] ;
            A226CierreMCMes = CIERREMENS2_A226CierreMCMes[0] ;
            A225CierreMCAnio = CIERREMENS2_A225CierreMCAnio[0] ;
            A41ClinicaCodigo = CIERREMENS2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CIERREMENS2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0056

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CierreMCAnio = A225CierreMCAnio ;
            AV4CierreMCMes = A226CierreMCMes ;
            AV5CtaContableCodigo = A193CtaContableCodigo ;
            AV6CierreMCDebe = A227CierreMCDebe ;
            AV7CierreMCHaber = A228CierreMCHaber ;
            /* Using cursor CIERREMENS3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CierreMCAnio, AV4CierreMCMes, AV5CtaContableCodigo, AV6CierreMCDebe, AV7CierreMCHaber});
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
         CIERREMENS2_A228CierreMCHaber = new decimal[1] ;
         CIERREMENS2_A227CierreMCDebe = new decimal[1] ;
         CIERREMENS2_A193CtaContableCodigo = new String[] {""} ;
         CIERREMENS2_A226CierreMCMes = new short[1] ;
         CIERREMENS2_A225CierreMCAnio = new short[1] ;
         CIERREMENS2_A41ClinicaCodigo = new String[] {""} ;
         CIERREMENS2_A40000GXC1 = new int[1] ;
         A193CtaContableCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV5CtaContableCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cierremensualcconversion__default(),
            new Object[][] {
                new Object[] {
               CIERREMENS2_A228CierreMCHaber, CIERREMENS2_A227CierreMCDebe, CIERREMENS2_A193CtaContableCodigo, CIERREMENS2_A226CierreMCMes, CIERREMENS2_A225CierreMCAnio, CIERREMENS2_A41ClinicaCodigo, CIERREMENS2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A226CierreMCMes ;
      private short A225CierreMCAnio ;
      private short AV3CierreMCAnio ;
      private short AV4CierreMCMes ;
      private int A40000GXC1 ;
      private int GIGXA0056 ;
      private int AV2ClinicaCodigo ;
      private decimal A228CierreMCHaber ;
      private decimal A227CierreMCDebe ;
      private decimal AV6CierreMCDebe ;
      private decimal AV7CierreMCHaber ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A193CtaContableCodigo ;
      private String A41ClinicaCodigo ;
      private String AV5CtaContableCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] CIERREMENS2_A228CierreMCHaber ;
      private decimal[] CIERREMENS2_A227CierreMCDebe ;
      private String[] CIERREMENS2_A193CtaContableCodigo ;
      private short[] CIERREMENS2_A226CierreMCMes ;
      private short[] CIERREMENS2_A225CierreMCAnio ;
      private String[] CIERREMENS2_A41ClinicaCodigo ;
      private int[] CIERREMENS2_A40000GXC1 ;
   }

   public class cierremensualcconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCIERREMENS2 ;
          prmCIERREMENS2 = new Object[] {
          } ;
          Object[] prmCIERREMENS3 ;
          prmCIERREMENS3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV4CierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5CtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV6CierreMCDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV7CierreMCHaber",SqlDbType.Decimal,17,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("CIERREMENS2", "SELECT [CierreMCHaber], [CierreMCDebe], [CtaContableCodigo], [CierreMCMes], [CierreMCAnio], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [CierreMensualC] ORDER BY [ClinicaCodigo], [CierreMCAnio], [CierreMCMes], [CtaContableCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCIERREMENS2,100,0,true,false )
             ,new CursorDef("CIERREMENS3", "INSERT INTO [GXA0056] ([ClinicaCodigo], [CierreMCAnio], [CierreMCMes], [CtaContableCodigo], [CierreMCDebe], [CierreMCHaber]) VALUES (@AV2ClinicaCodigo, @AV3CierreMCAnio, @AV4CierreMCMes, @AV5CtaContableCodigo, @AV6CierreMCDebe, @AV7CierreMCHaber)", GxErrorMask.GX_NOMASK,prmCIERREMENS3)
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                break;
       }
    }

 }

}
