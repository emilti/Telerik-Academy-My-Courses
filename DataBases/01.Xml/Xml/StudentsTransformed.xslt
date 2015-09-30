<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="html" />
  <xsl:template match="/">   
    	        
    <html>
      <title>Academy</title>
      <body>       
       <xsl:for-each select="students/student">
          <!--<xsl:value-of select="current()"/> -->
         <div style="border: 1px solid black; background-color:grey; margin-left:10px; border-radius:5px; width:20%; padding:20px; float:left">
           <h4>Name: <xsl:value-of select="name"/></h4><br />
           Sex: <xsl:value-of select="sex"/> <br />
           Birth Date<xsl:value-of select="birth-date"/><br />
           Phone: <xsl:value-of select="phone"/><br />
           Email: <xsl:value-of select="email"/><br />
           Course: <xsl:value-of select="course"/><br />
           Specialty: <xsl:value-of select="specialty"/><br />
           Faculty Number: <xsl:value-of select="faculty-number"/><br />
           <xsl:for-each select="exams/exam">
             <div>              
               <span style="font-weight:bold">
                 Exam: <xsl:value-of select="name"/>
               </span><br />
             Tutor: <xsl:value-of select="tutor"/><br />
             Score: <xsl:value-of select="score"/><br />
             </div>
           </xsl:for-each>
           <br />           
           Enrollment date: <xsl:value-of select="enrollment/enrollment-date"/><br />
           Enrollment score: <xsl:value-of select="enrollment/exam-score"/><br />
           <span style="font-weight:bold">Endorsements</span><br/>
           <xsl:for-each select="teacher-endorsements/endorsement">
             Teacher: <xsl:value-of select="teacher-name"/><br/>
             Endorsement: <xsl:value-of select="opinion"/><br/>
           </xsl:for-each>
         </div>
        </xsl:for-each>
      </body>
    </html>
    
  </xsl:template>


  
</xsl:stylesheet>
