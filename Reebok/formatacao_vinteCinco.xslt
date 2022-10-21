<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>


	<xsl:template match="/">
		<xsl:for-each select="/rss/channel/item">
			<xsl:if test="position() &lt;= 25">  <!--Se a position for menor ou igual a 25-->
				<div class="col-lg-4 col-md-6 col-12" data-aos="fade-up" data-aos-delay="400">
					<div class="class-thumb">
						<img src="{enclosure/@url}" class="img-fluid" alt="Class"></img>
						<div class="class-info">
							<h3 class="mb-1">
								<xsl:value-of select="title" disable-output-escaping="yes"/>
							</h3>
							<p class="mt-3">   </p>
						</div>
					</div>
				</div>
			</xsl:if>
		</xsl:for-each>
		<div style="clear: both"></div>  <!--flutuação e limpeza do css-->

	</xsl:template>
</xsl:stylesheet>
