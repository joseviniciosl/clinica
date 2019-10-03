/*
               File: oObtieneCorrelativoMovInv
        Description: Obtiene Correlativo del Movimiento de Inventario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:50.13
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
   public class oobtienecorrelativomovinv : GXProcedure
   {
      public oobtienecorrelativomovinv( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienecorrelativomovinv( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_ClinicaCodigo ,
                           String aP1_TipoMICodigo ,
                           out int aP2_TipoMICorrelativo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A114TipoMICodigo = aP1_TipoMICodigo;
         this.AV8TipoMICorrelativo = 0 ;
         initialize();
         executePrivate();
         aP2_TipoMICorrelativo=this.AV8TipoMICorrelativo;
      }

      public int executeUdp( String aP0_ClinicaCodigo ,
                             String aP1_TipoMICodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A114TipoMICodigo = aP1_TipoMICodigo;
         this.AV8TipoMICorrelativo = 0 ;
         initialize();
         executePrivate();
         aP2_TipoMICorrelativo=this.AV8TipoMICorrelativo;
         return AV8TipoMICorrelativo ;
      }

      public void executeSubmit( String aP0_ClinicaCodigo ,
                                 String aP1_TipoMICodigo ,
                                 out int aP2_TipoMICorrelativo )
      {
         oobtienecorrelativomovinv objoobtienecorrelativomovinv;
         objoobtienecorrelativomovinv = new oobtienecorrelativomovinv();
         objoobtienecorrelativomovinv.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienecorrelativomovinv.A114TipoMICodigo = aP1_TipoMICodigo;
         objoobtienecorrelativomovinv.AV8TipoMICorrelativo = 0 ;
         objoobtienecorrelativomovinv.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienecorrelativomovinv);
         aP2_TipoMICorrelativo=this.AV8TipoMICorrelativo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienecorrelativomovinv)stateInfo).executePrivate();
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
         AV12GXLvl2 = 0 ;
         /* Using cursor P000W2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, Gx_date});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A119TipoMIAnio = P000W2_A119TipoMIAnio[0] ;
            A120TipoMICorrelativo = P000W2_A120TipoMICorrelativo[0] ;
            AV12GXLvl2 = 1 ;
            AV8TipoMICorrelativo = A120TipoMICorrelativo ;
            A120TipoMICorrelativo = (int)(A120TipoMICorrelativo+1) ;
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8TipoMICorrelativo), 10, 0))) == 1 )
            {
               AV9TipoMICorrelativoC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "0000" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8TipoMICorrelativo), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8TipoMICorrelativo), 10, 0))) == 2 )
            {
               AV9TipoMICorrelativoC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "000" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8TipoMICorrelativo), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8TipoMICorrelativo), 10, 0))) == 3 )
            {
               AV9TipoMICorrelativoC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "00" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8TipoMICorrelativo), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8TipoMICorrelativo), 10, 0))) == 4 )
            {
               AV9TipoMICorrelativoC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "0" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8TipoMICorrelativo), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8TipoMICorrelativo), 10, 0))) == 5 )
            {
               AV9TipoMICorrelativoC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + StringUtil.Trim( StringUtil.Str( (decimal)(AV8TipoMICorrelativo), 10, 0)) ;
            }
            /* Using cursor P000W3 */
            pr_default.execute(1, new Object[] {A120TipoMICorrelativo, A41ClinicaCodigo, A114TipoMICodigo, A119TipoMIAnio});
            pr_default.close(1);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV12GXLvl2 == 0 )
         {
            /*
               INSERT RECORD ON TABLE TipoMovInventarioDet

            */
            A119TipoMIAnio = (short)(DateTimeUtil.Year( Gx_date)) ;
            A120TipoMICorrelativo = 2 ;
            AV9TipoMICorrelativoC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "00001" ;
            /* Using cursor P000W4 */
            pr_default.execute(2, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A119TipoMIAnio, A120TipoMICorrelativo});
            pr_default.close(2);
            if ( (pr_default.getStatus(2) == 1) )
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
         }
         AV8TipoMICorrelativo = (int)(NumberUtil.Val( AV9TipoMICorrelativoC, ".")) ;
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("oObtieneCorrelativoMovInv");
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
         Gx_date = DateTime.MinValue ;
         P000W2_A41ClinicaCodigo = new String[] {""} ;
         P000W2_A114TipoMICodigo = new String[] {""} ;
         P000W2_A119TipoMIAnio = new short[1] ;
         P000W2_A120TipoMICorrelativo = new int[1] ;
         AV9TipoMICorrelativoC = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienecorrelativomovinv__default(),
            new Object[][] {
                new Object[] {
               P000W2_A41ClinicaCodigo, P000W2_A114TipoMICodigo, P000W2_A119TipoMIAnio, P000W2_A120TipoMICorrelativo
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short AV12GXLvl2 ;
      private short A119TipoMIAnio ;
      private int AV8TipoMICorrelativo ;
      private int A120TipoMICorrelativo ;
      private int GX_INS29 ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime Gx_date ;
      private String A41ClinicaCodigo ;
      private String A114TipoMICodigo ;
      private String AV9TipoMICorrelativoC ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000W2_A41ClinicaCodigo ;
      private String[] P000W2_A114TipoMICodigo ;
      private short[] P000W2_A119TipoMIAnio ;
      private int[] P000W2_A120TipoMICorrelativo ;
      private int aP2_TipoMICorrelativo ;
   }

   public class oobtienecorrelativomovinv__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000W2 ;
          prmP000W2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@Gx_date",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP000W3 ;
          prmP000W3 = new Object[] {
          new Object[] {"@TipoMICorrelativo",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMIAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000W4 ;
          prmP000W4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMIAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoMICorrelativo",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000W2", "SELECT [ClinicaCodigo], [TipoMICodigo], [TipoMIAnio], [TipoMICorrelativo] FROM [TipoMovInventarioDet] WITH (UPDLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] = @TipoMICodigo) AND ([TipoMIAnio] = YEAR(@Gx_date)) ORDER BY [ClinicaCodigo], [TipoMICodigo] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000W2,1,0,true,false )
             ,new CursorDef("P000W3", "UPDATE [TipoMovInventarioDet] SET [TipoMICorrelativo]=@TipoMICorrelativo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [TipoMIAnio] = @TipoMIAnio", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000W3)
             ,new CursorDef("P000W4", "INSERT INTO [TipoMovInventarioDet] ([ClinicaCodigo], [TipoMICodigo], [TipoMIAnio], [TipoMICorrelativo]) VALUES (@ClinicaCodigo, @TipoMICodigo, @TipoMIAnio, @TipoMICorrelativo)", GxErrorMask.GX_NOMASK,prmP000W4)
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
