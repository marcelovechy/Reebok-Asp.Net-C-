<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    

    <xsl:template match="/">

		<thead class="thead-light">
			<th>Modelo</th>
			<th>Peso</th>
			<th>Preço</th>
			<th>Genero</th>
			<th>Foto</th>
		</thead>
		<tbody>
			<xsl:for-each select="/reebok/tenis[genero='Homem']">
				<tr>
					<td>
						<strong>
							<xsl:value-of select="modelo"/>
						</strong>
					</td>
					<td>
						<strong>
							<xsl:value-of select="peso"/>
						</strong>
					</td>
					<td>
						<strong>
							<xsl:value-of select="preco"/>
						</strong>
					</td>
					<td>
						<strong>
							<xsl:value-of select="genero"/>
						</strong>
					</td>
					<td>
						<strong>
							<img src="{foto}" width="190px" height="150px"></img>
						</strong>
					</td>
				</tr>
			</xsl:for-each>
		</tbody>
	</xsl:template>
</xsl:stylesheet>
