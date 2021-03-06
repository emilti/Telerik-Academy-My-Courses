﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="html" />
  <xsl:template match="/">
    <html>
      <title>Catalogue</title>
      <body>
        <div style="width:1000px overflow:hidden; border:1px solid #ccc;">
          <xsl:for-each select="catalogue/album">
            <!--<xsl:value-of select="current()"/> -->
            <div style="border: 1px solid black; background-color:grey;  margin:10px;border-radius:5px; height:300px; width:140px; padding:20px; display:inline-block ">
              <h4>
                Name: <xsl:value-of select="name"/>
              </h4><br />
              Artist: <xsl:value-of select="artist"/> <br />
              Producer: <xsl:value-of select="producer"/><br />
              Price: <xsl:value-of select="price"/><br />
              Year of Release: <xsl:value-of select="year-of-release"/><br />
              <xsl:for-each select="songs/song">
                <div style="position:relatve;display:inline-block">
                  <span style="font-weight:bold">
                    Song name: <xsl:value-of select="title"/>
                  </span><br />
                  Duration: <xsl:value-of select="duration"/><br />
                </div>
              </xsl:for-each>
            </div>
          </xsl:for-each>
        </div>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
