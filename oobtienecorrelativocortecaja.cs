/*
               File: oObtieneCorrelativoCorteCaja
        Description: Obtiene Correlativo del Corte de Caja
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:48.62
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
   public class oobtienecorrelativocortecaja : GXProcedure
   {
      public oobtienecorrelativocortecaja( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienecorrelativocortecaja( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_ClinicaCodigo ,
                           String aP1_CajaCodigo ,
                           out int aP2_CajaSiguiente )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A132CajaCodigo = aP1_CajaCodigo;
         this.AV8CajaSiguiente = 0 ;
         initialize();
         executePrivate();
         aP2_CajaSiguiente=this.AV8CajaSiguiente;
      }

      public int executeUdp( String aP0_ClinicaCodigo ,
                             String aP1_CajaCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A132CajaCodigo = aP1_CajaCodigo;
         this.AV8CajaSiguiente = 0 ;
         initialize();
         executePrivate();
         aP2_CajaSiguiente=this.AV8CajaSiguiente;
         return AV8CajaSiguiente ;
      }

      public void executeSubmit( String aP0_ClinicaCodigo ,
                                 String aP1_CajaCodigo ,
                                 out int aP2_CajaSiguiente )
      {
         oobtienecorrelativocortecaja objoobtienecorrelativocortecaja;
         objoobtienecorrelativocortecaja = new oobtienecorrelativocortecaja();
         objoobtienecorrelativocortecaja.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienecorrelativocortecaja.A132CajaCodigo = aP1_CajaCodigo;
         objoobtienecorrelativocortecaja.AV8CajaSiguiente = 0 ;
         objoobtienecorrelativocortecaja.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienecorrelativocortecaja);
         aP2_CajaSiguiente=this.AV8CajaSiguiente;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienecorrelativocortecaja)stateInfo).executePrivate();
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
         /* Using cursor P000U2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A132CajaCodigo, Gx_date});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A135CajaAnio = P000U2_A135CajaAnio[0] ;
            A136CajaSiguiente = P000U2_A136CajaSiguiente[0] ;
            AV12GXLvl2 = 1 ;
            AV8CajaSiguiente = A136CajaSiguiente ;
            A136CajaSiguiente = (int)(A136CajaSiguiente+1) ;
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8CajaSiguiente), 10, 0))) == 1 )
            {
               AV9CajaSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "0000" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8CajaSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8CajaSiguiente), 10, 0))) == 2 )
            {
               AV9CajaSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "000" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8CajaSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8CajaSiguiente), 10, 0))) == 3 )
            {
               AV9CajaSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "00" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8CajaSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8CajaSiguiente), 10, 0))) == 4 )
            {
               AV9CajaSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "0" + StringUtil.Trim( StringUtil.Str( (decimal)(AV8CajaSiguiente), 10, 0)) ;
            }
            if ( StringUtil.Len( StringUtil.Trim( StringUtil.Str( (decimal)(AV8CajaSiguiente), 10, 0))) == 5 )
            {
               AV9CajaSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + StringUtil.Trim( StringUtil.Str( (decimal)(AV8CajaSiguiente), 10, 0)) ;
            }
            /* Using cursor P000U3 */
            pr_default.execute(1, new Object[] {A136CajaSiguiente, A41ClinicaCodigo, A132CajaCodigo, A135CajaAnio});
            pr_default.close(1);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV12GXLvl2 == 0 )
         {
            /*
               INSERT RECORD ON TABLE CajaCorrelativo

            */
            A135CajaAnio = (short)(DateTimeUtil.Year( Gx_date)) ;
            A136CajaSiguiente = 2 ;
            AV9CajaSiguienteC = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( Gx_date)), 10, 0)) + "00001" ;
            /* Using cursor P000U4 */
            pr_default.execute(2, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A135CajaAnio, A136CajaSiguiente});
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
         AV8CajaSiguiente = (int)(NumberUtil.Val( AV9CajaSiguienteC, ".")) ;
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("oObtieneCorrelativoCorteCaja");
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
         P000U2_A41ClinicaCodigo = new String[] {""} ;
         P000U2_A132CajaCodigo = new String[] {""} ;
         P000U2_A135CajaAnio = new short[1] ;
         P000U2_A136CajaSiguiente = new int[1] ;
         AV9CajaSiguienteC = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienecorrelativocortecaja__default(),
            new Object[][] {
                new Object[] {
               P000U2_A41ClinicaCodigo, P000U2_A132CajaCodigo, P000U2_A135CajaAnio, P000U2_A136CajaSiguiente
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
      private short A135CajaAnio ;
      private int AV8CajaSiguiente ;
      private int A136CajaSiguiente ;
      private int GX_INS37 ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime Gx_date ;
      private String A41ClinicaCodigo ;
      private String A132CajaCodigo ;
      private String AV9CajaSiguienteC ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000U2_A41ClinicaCodigo ;
      private String[] P000U2_A132CajaCodigo ;
      private short[] P000U2_A135CajaAnio ;
      private int[] P000U2_A136CajaSiguiente ;
      private int aP2_CajaSiguiente ;
   }

   public class oobtienecorrelativocortecaja__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000U2 ;
          prmP000U2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@Gx_date",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP000U3 ;
          prmP000U3 = new Object[] {
          new Object[] {"@CajaSiguiente",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000U4 ;
          prmP000U4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CajaSiguiente",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000U2", "SELECT [ClinicaCodigo], [CajaCodigo], [CajaAnio], [CajaSiguiente] FROM [CajaCorrelativo] WITH (UPDLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo and [CajaCodigo] = @CajaCodigo) AND ([CajaAnio] = YEAR(@Gx_date)) ORDER BY [ClinicaCodigo], [CajaCodigo] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000U2,1,0,true,false )
             ,new CursorDef("P000U3", "UPDATE [CajaCorrelativo] SET [CajaSiguiente]=@CajaSiguiente  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CajaAnio] = @CajaAnio", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000U3)
             ,new CursorDef("P000U4", "INSERT INTO [CajaCorrelativo] ([ClinicaCodigo], [CajaCodigo], [CajaAnio], [CajaSiguiente]) VALUES (@ClinicaCodigo, @CajaCodigo, @CajaAnio, @CajaSiguiente)", GxErrorMask.GX_NOMASK,prmP000U4)
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
