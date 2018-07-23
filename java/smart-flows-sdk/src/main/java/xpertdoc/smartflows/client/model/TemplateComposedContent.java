/*
 * Xpertdoc SmartFlows
 * This describes the REST api for one Xpertdoc SmartFlows project
 *
 * OpenAPI spec version: 4.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package xpertdoc.smartflows.client.model;

import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * The content of the template when type is composed. Content of standard templates should be retrieved using the contentLink
 */
@ApiModel(description = "The content of the template when type is composed. Content of standard templates should be retrieved using the contentLink")
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class TemplateComposedContent {
  @SerializedName("bodies")
  private List<Part> bodies = null;

  @SerializedName("headers")
  private List<Part> headers = null;

  @SerializedName("footers")
  private List<Part> footers = null;

  @SerializedName("additions")
  private List<Part> additions = null;

  public TemplateComposedContent bodies(List<Part> bodies) {
    this.bodies = bodies;
    return this;
  }

  public TemplateComposedContent addBodiesItem(Part bodiesItem) {
    if (this.bodies == null) {
      this.bodies = new ArrayList<Part>();
    }
    this.bodies.add(bodiesItem);
    return this;
  }

   /**
   * Get bodies
   * @return bodies
  **/
  @ApiModelProperty(value = "")
  public List<Part> getBodies() {
    return bodies;
  }

  public void setBodies(List<Part> bodies) {
    this.bodies = bodies;
  }

  public TemplateComposedContent headers(List<Part> headers) {
    this.headers = headers;
    return this;
  }

  public TemplateComposedContent addHeadersItem(Part headersItem) {
    if (this.headers == null) {
      this.headers = new ArrayList<Part>();
    }
    this.headers.add(headersItem);
    return this;
  }

   /**
   * Get headers
   * @return headers
  **/
  @ApiModelProperty(value = "")
  public List<Part> getHeaders() {
    return headers;
  }

  public void setHeaders(List<Part> headers) {
    this.headers = headers;
  }

  public TemplateComposedContent footers(List<Part> footers) {
    this.footers = footers;
    return this;
  }

  public TemplateComposedContent addFootersItem(Part footersItem) {
    if (this.footers == null) {
      this.footers = new ArrayList<Part>();
    }
    this.footers.add(footersItem);
    return this;
  }

   /**
   * Get footers
   * @return footers
  **/
  @ApiModelProperty(value = "")
  public List<Part> getFooters() {
    return footers;
  }

  public void setFooters(List<Part> footers) {
    this.footers = footers;
  }

  public TemplateComposedContent additions(List<Part> additions) {
    this.additions = additions;
    return this;
  }

  public TemplateComposedContent addAdditionsItem(Part additionsItem) {
    if (this.additions == null) {
      this.additions = new ArrayList<Part>();
    }
    this.additions.add(additionsItem);
    return this;
  }

   /**
   * Get additions
   * @return additions
  **/
  @ApiModelProperty(value = "")
  public List<Part> getAdditions() {
    return additions;
  }

  public void setAdditions(List<Part> additions) {
    this.additions = additions;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TemplateComposedContent templateComposedContent = (TemplateComposedContent) o;
    return Objects.equals(this.bodies, templateComposedContent.bodies) &&
        Objects.equals(this.headers, templateComposedContent.headers) &&
        Objects.equals(this.footers, templateComposedContent.footers) &&
        Objects.equals(this.additions, templateComposedContent.additions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bodies, headers, footers, additions);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TemplateComposedContent {\n");
    
    sb.append("    bodies: ").append(toIndentedString(bodies)).append("\n");
    sb.append("    headers: ").append(toIndentedString(headers)).append("\n");
    sb.append("    footers: ").append(toIndentedString(footers)).append("\n");
    sb.append("    additions: ").append(toIndentedString(additions)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

