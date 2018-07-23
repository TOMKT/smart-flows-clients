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

import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModelProperty;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * DependencyTreeNode
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class DependencyTreeNode {
  @SerializedName("target")
  private IdWithName target = null;

  /**
   * Gets or Sets loaded
   */
  @JsonAdapter(LoadedEnum.Adapter.class)
  public enum LoadedEnum {
    EAGER("eager"),
    
    LAZY("lazy");

    private String value;

    LoadedEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static LoadedEnum fromValue(String text) {
      for (LoadedEnum b : LoadedEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<LoadedEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final LoadedEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public LoadedEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return LoadedEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("loaded")
  private LoadedEnum loaded = LoadedEnum.LAZY;

  @SerializedName("children")
  private List<DependencyTreeNode> children = null;

  public DependencyTreeNode target(IdWithName target) {
    this.target = target;
    return this;
  }

   /**
   * Get target
   * @return target
  **/
  @ApiModelProperty(value = "")
  public IdWithName getTarget() {
    return target;
  }

  public void setTarget(IdWithName target) {
    this.target = target;
  }

  public DependencyTreeNode loaded(LoadedEnum loaded) {
    this.loaded = loaded;
    return this;
  }

   /**
   * Get loaded
   * @return loaded
  **/
  @ApiModelProperty(value = "")
  public LoadedEnum getLoaded() {
    return loaded;
  }

  public void setLoaded(LoadedEnum loaded) {
    this.loaded = loaded;
  }

  public DependencyTreeNode children(List<DependencyTreeNode> children) {
    this.children = children;
    return this;
  }

  public DependencyTreeNode addChildrenItem(DependencyTreeNode childrenItem) {
    if (this.children == null) {
      this.children = new ArrayList<DependencyTreeNode>();
    }
    this.children.add(childrenItem);
    return this;
  }

   /**
   * Get children
   * @return children
  **/
  @ApiModelProperty(value = "")
  public List<DependencyTreeNode> getChildren() {
    return children;
  }

  public void setChildren(List<DependencyTreeNode> children) {
    this.children = children;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DependencyTreeNode dependencyTreeNode = (DependencyTreeNode) o;
    return Objects.equals(this.target, dependencyTreeNode.target) &&
        Objects.equals(this.loaded, dependencyTreeNode.loaded) &&
        Objects.equals(this.children, dependencyTreeNode.children);
  }

  @Override
  public int hashCode() {
    return Objects.hash(target, loaded, children);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DependencyTreeNode {\n");
    
    sb.append("    target: ").append(toIndentedString(target)).append("\n");
    sb.append("    loaded: ").append(toIndentedString(loaded)).append("\n");
    sb.append("    children: ").append(toIndentedString(children)).append("\n");
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

